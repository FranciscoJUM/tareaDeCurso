using Dominio.Entidades;
using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IMetodos : IModel
    {
        Gastos[] BuscarPorFechaGastos(DateTime f);
        Ingresos[] BuscarPorFechaIngresos(DateTime f);

        string GetProductosAsJsonDeIngresos();
        string getProductosAsJsonGastos();

        Gastos[] BuscarPorEnumGasto(EnumGastos x);
        Ingresos[] BuscarPorEnumIngreso(EnumIngreso x);

        Gastos[] BuscarPorRangoDePrecioGastos(decimal a, decimal z);
        Ingresos[] BuscaraPorRangoDePrecioIngresos(decimal a, decimal z);

        int GetLastIngresoId();
        int GetLastGastosId();
    }
}
