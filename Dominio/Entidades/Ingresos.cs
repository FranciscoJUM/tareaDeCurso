using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Ingresos
    {
        public int Id { get; set; }
        public decimal Cantidad { get; set; }
        public EnumIngreso enumIngreso { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
