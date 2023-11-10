using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Proveedor
    {
        public int IDProveedor { get; set; }
        public string Nit { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Nomenclatura { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
    }
}
