-- Active: 1694175337411@@127.0.0.1@3306@minimarket
USE minimarket;

CREATE Table minimarket(
    idMinimarket INT AUTO_INCREMENT,
    nit VARCHAR(15)NOT NULL,
    razonSocial VARCHAR(50)NOT NULL,
    telefono VARCHAR(10)NOT NULL,
    nomenclatura VARCHAR(50)NOT NULL,
    ciudad VARCHAR(50)NOT NULL,
    departamento VARCHAR(50)NOT NULL,
    correo VARCHAR(50)NOT NULL,
    sitioWeb VARCHAR(50)NOT NULL,
    facebook VARCHAR(50)NOT NULL,
    whatsapp VARCHAR(10)NOT NULL,
    CONSTRAINT pk_minimarket PRIMARY KEY (idMinimarket),
    CONSTRAINT unico_nit UNIQUE (nit),
    CONSTRAINT unico_razonSocial UNIQUE (razonSocial));

CREATE TABLE categoria (
    idCategoria INT AUTO_INCREMENT,
    nombre VARCHAR(50)NOT NULL,
    descripcion VARCHAR(50)NULL,
    CONSTRAINT pk_categoria PRIMARY KEY (idCategoria),
    CONSTRAINT unico_nombre UNIQUE (nombre));

CREATE TABLE cliente (
    idCliente int AUTO_INCREMENT,
    tipoDoc ENUM ('CC','TI','PAS','PEP','PPT','CE','Otro'),
    identificacion VARCHAR(11)NOT NULL,
    nombres VARCHAR(50)NOT NULL,
    apellidos VARCHAR(50)NOT NULL,
    correo VARCHAR(50)NOT NULL,
    celular VARCHAR(11)NOT NULL,
    CONSTRAINT pk_cliente PRIMARY KEY (idCliente),
    CONSTRAINT unico_identificacion UNIQUE (identificacion));

CREATE Table proveedor(
    idProveedor INT AUTO_INCREMENT,
    nit VARCHAR(15)NOT NULL,
    razonSocial VARCHAR(50)NOT NULL,
    telefono VARCHAR(10)NOT NULL,
    correo VARCHAR(50)NOT NULL,
    nomenclatura VARCHAR(50)NOT NULL,
    ciudad VARCHAR(50)NOT NULL,
    departamento VARCHAR(50)NOT NULL,
    CONSTRAINT pk_proveedor PRIMARY KEY (idProveedor),
    CONSTRAINT unico_nit_proveedor UNIQUE (nit),
    CONSTRAINT unico_razonSocial_proveedor UNIQUE (razonSocial), 
    CONSTRAINT unico_correo_proveedor UNIQUE (correo));   

CREATE TABLE producto (
    idProducto INT AUTO_INCREMENT,
    nombre VARCHAR(50)NOT NULL,
    marca VARCHAR(50)NOT NULL,
    stock INT DEFAULT 0,
    pvp INT NOT NULL DEFAULT 0,
    descripcion VARCHAR(200) NULL,
    unidadMedida ENUM('UND','gr'),
    idCategoria INT NOT NULL,
    CONSTRAINT pk_producto PRIMARY KEY (idProducto),
    CONSTRAINT unico_nombre UNIQUE (nombre),
    CONSTRAINT fk_categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria));

CREATE TABLE empleado (
    idEmpleado int AUTO_INCREMENT,
    tipoDoc ENUM ('CC','TI','PAS','PEP','PPT','CE','Otro'),
    identificacion VARCHAR(11)NOT NULL,
    nombres VARCHAR(50)NOT NULL,
    apellidos VARCHAR(50)NOT NULL,
    correo VARCHAR(50)NOT NULL,
    celular VARCHAR(11)NOT NULL,
    clave VARCHAR(8)NOT NULL,
    idMinimarket INT NOT NULL,
    CONSTRAINT pk_empleado PRIMARY KEY (idEmpleado),
    CONSTRAINT unico_identificacion_empleado UNIQUE (identificacion),
    CONSTRAINT unico_correo_empleado UNIQUE (correo),
    CONSTRAINT fk_minimarket FOREIGN KEY (idMinimarket) REFERENCES Minimarket (idMinimarket));

CREATE TABLE factura (
    idFactura int AUTO_INCREMENT,
    codigoFactura VARCHAR(8)NOT NULL,
    fechaGeneracion DATETIME NOT NULL,
    iva INT NOT NULL,
    sinIva INT NOT NULL,
    total INT NOT NULL,
    idEmpleado INT NOT NULL,
    idCliente INT NOT NULL,
    CONSTRAINT pk_factura PRIMARY KEY (idFactura),
    CONSTRAINT unico_factura UNIQUE (codigoFactura),
    CONSTRAINT fk_empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado),
    CONSTRAINT fk_cliente FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente));

CREATE TABLE detalleFactura(
    idDetalleFactura int AUTO_INCREMENT,
    cantidadProductos int not NULL,
    precioUnitario int not Null,
    subtotal int not Null,
    idFactura int not Null,
    idProducto int not NULL,
    CONSTRAINT pk_detalleFactura PRIMARY KEY(idDetalleFactura),
    CONSTRAINT fk_factura FOREIGN KEY(idFactura) REFERENCES Factura(idFactura),
    CONSTRAINT fk_producto FOREIGN KEY(idProducto) REFERENCES Producto(idProducto));

CREATE TABLE ordenCompra(
    idOrdenCompra int AUTO_INCREMENT,
    codigoOrden int not NULL,
    iva int not Null,
    total int not Null,
    fechaPedido DATETIME not Null,
    fechaEntrega DATETIME not NULL,
    sinIva int not NULL,
    idEmpleado int not NULL,
    idProveedor int not NULL,
    CONSTRAINT pk_ordenCompra PRIMARY KEY(idOrdenCompra),
    CONSTRAINT unico_ordenCompra UNIQUE (codigoOrden),
    CONSTRAINT fk_empleado1 FOREIGN KEY(idEmpleado) REFERENCES Empleado(idEmpleado),
    CONSTRAINT fk_proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(idProveedor));

CREATE TABLE detalleOrdenCompra(
    idDetalleOrden int AUTO_INCREMENT,
    codigoDetalleOrden int not NULL,
    cantidadProductos int not NULL,
    precioCompra int not NULL,
    subtotal int not Null,
    idOrdenCompra int not Null,
    idProducto int not NULL,
    CONSTRAINT pk_detalleOrdenCompra PRIMARY KEY(idDetalleOrden),
    CONSTRAINT unico_detalleOrdenCompra UNIQUE (codigoDetalleOrden),
    CONSTRAINT fk_ordenCompra FOREIGN KEY(idOrdenCompra) REFERENCES OrdenCompra(idOrdenCompra),
    CONSTRAINT fk_producto1 FOREIGN KEY(idProducto) REFERENCES Producto(idProducto));

SELECT idCategoria FROM categoria WHERE nombre = @nombreCategoria