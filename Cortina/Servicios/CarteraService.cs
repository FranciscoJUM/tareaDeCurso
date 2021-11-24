using Cortina.Interfces;
using Dominio.Entidades;
using Dominio.Enums;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cortina.Servicios
{
    public class CarteraService : ICarteraService
    {
       private  IMetodos met;
        
        public CarteraService(IMetodos met)
        {
            
            this.met = met;
        }

        #region CRDS

        public int UpdateGastos(Gastos t)
        {
            return met.UpdateGastos(t);
        }
        public int UpdateIngresos(Ingresos t)
        {
            return met.UpdateIngresos(t);
        }

        public Gastos[] FindAll()
        {
            return met.FindAll();
        }
        public Ingresos[] Findall()
        {
            return met.Findall();
        }

        public void crearGastos(Gastos t)
        {
            met.crearGastos(t);
        }
        public void crearIngresos(Ingresos t)
        {
            met.crearIngresos(t);
        }

        public bool DaleteIngresos(Ingresos t)
        {
            return met.DaleteIngresos(t);
        }
        public bool DeleteGastos(Gastos t)
        {
            return met.DeleteGastos(t);
        }



        #endregion

        #region Metodos

        public Gastos[] BuscarPorRangoDePrecioGastos(decimal a, decimal z)
        {
            return met.BuscarPorRangoDePrecioGastos(a, z);
        }
        public Ingresos[] BuscaraPorRangoDePrecioIngresos(decimal a, decimal z)
        {
            return met.BuscaraPorRangoDePrecioIngresos(a, z);
        }

        public Gastos[] BuscarPorEnumGasto(EnumGastos x)
        {
            return met.BuscarPorEnumGasto(x);
        }
        public Ingresos[] BuscarPorEnumIngreso(EnumIngreso x)
        {
            return met.BuscarPorEnumIngreso(x);
        }

        public Gastos[] BuscarPorFechaGastos(DateTime f)
        {
            return met.BuscarPorFechaGastos(f);
        }
        public Ingresos[] BuscarPorFechaIngresos(DateTime f)
        {
            return met.BuscarPorFechaIngresos(f);
        }

        public string GetProductosAsJsonDeIngresos()
        {
            return met.GetProductosAsJsonDeIngresos();
        }
        public string getProductosAsJsonGastos()
        {
            return met.getProductosAsJsonGastos();
        }

        public int GetLastGastosId()
        {
            return met.GetLastGastosId();
        }
        public int GetLastIngresoId()
        {
            return met.GetLastIngresoId();
        }
        #endregion












    }
}
