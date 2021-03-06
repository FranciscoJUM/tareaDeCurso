using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cortina.Interfces
{
    public interface IModelService
    {
        void crearGastos(Gastos t);
        void crearIngresos(Ingresos t);

        int UpdateGastos(Gastos t);
        int UpdateIngresos(Ingresos t);

        bool DeleteGastos(Gastos t);
        bool DaleteIngresos(Ingresos t);

        Gastos[] FindAll();
        Ingresos[] Findall();
    }
}
