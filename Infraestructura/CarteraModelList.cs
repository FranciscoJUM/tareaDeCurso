using Dominio.Entidades;
using Dominio.Enums;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class CarteraModelList : IMetodos
    {
        private List<Gastos> gas;
        private List<Ingresos> ing;


        #region Cruds
        public int UpdateGastos(Gastos t)
        {
            return gas.Count();
        }
        public int UpdateIngresos(Ingresos t)
        {
            throw new NotImplementedException();
        }

        public Gastos[] FindAll()
        {
            return gas.ToArray();
        }
        public Ingresos[] Findall()
        {
            return ing.ToArray();
        }

        public void crearGastos(Gastos t)
        {
            gas.Add(t);
        }
        public void crearIngresos(Ingresos t)
        {
            ing.Add(t);
        }

        public bool DaleteIngresos(Ingresos t)
        {
            return ing.Remove(t);
        }
        public bool DeleteGastos(Gastos t)
        {
            return gas.Remove(t);  
        }

        #endregion

        #region Metodos
        

        public Ingresos[] BuscaraPorRangoDePrecioIngresos(decimal a, decimal z)
        {
            throw new NotImplementedException();
        }
        public Gastos[] BuscarPorEnumGasto(EnumGastos x)
        {
            throw new NotImplementedException();
        }

        public Ingresos[] BuscarPorEnumIngreso(EnumIngreso x)
        {
            throw new NotImplementedException();
        }
        public Gastos[] BuscarPorFechaGastos(DateTime f)
        {
            throw new NotImplementedException();
        }

        public Ingresos[] BuscarPorFechaIngresos(DateTime f)
        {
            throw new NotImplementedException();
        }
        public Gastos[] BuscarPorRangoDePrecioGastos(decimal a, decimal z)
        {
            throw new NotImplementedException();
        }

        public string GetProductosAsJsonDeIngresos()
        {
            throw new NotImplementedException();
        }
        public string getProductosAsJsonGastos()
        {
            throw new NotImplementedException();
        }

        public int GetLastIngresoId()
        {
            return ing == null ? 0 : ing[ing.Count - 1].Id;
        }
        public int GetLastGastosId()
        {
            return gas == null ? 0 : gas[gas.Count - 1].Id;
        }
        #endregion

        #region privados
        #endregion







    }
}
