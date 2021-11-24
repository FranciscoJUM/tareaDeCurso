using Dominio.Entidades;
using Dominio.Enums;
using Dominio.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
  public   class CarteraModel : IMetodos
    {
        private Gastos[] gas;
        private Ingresos[] ing;

        #region Cruds
        //Cruds
        public void crearGastos(Gastos t)
        {
            AddGasto(t, ref gas);
        }
        public void crearIngresos(Ingresos t)
        {
            AddIngreso(t, ref ing);
        }

        public int UpdateGastos(Gastos t)
        {
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexByIdGastos(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            gas[index] = t;
            return index;
        }
        public int UpdateIngresos(Ingresos t)
        {
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexByIdIngresos(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            ing[index] = t;
            return index;
        }

        public bool DeleteGastos(Gastos t)
        {

            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexByIdGastos(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            if (index != gas.Length - 1)
            {
                gas[index] = gas[gas.Length - 1];
            }

            Gastos[] tmp = new Gastos[gas.Length - 1];
            Array.Copy(gas, tmp, tmp.Length);
            gas = tmp;

            return gas.Length == tmp.Length;
        }
        public bool DaleteIngresos(Ingresos t)
        {

            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexByIdIngresos(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            if (index != ing.Length - 1)
            {
                ing[index] = ing[ing.Length - 1];
            }

            Ingresos[] tmp = new Ingresos[ing.Length - 1];
            Array.Copy(ing, tmp, tmp.Length);
            ing = tmp;

            return ing.Length == tmp.Length;
        }

        public Gastos[] FindAll()
        {
            return gas;
        }
        public Ingresos[] Findall()
        {
            return ing;
        }
        #endregion

        #region Metodos
        //Metodos 

        public Gastos[] BuscarPorFechaGastos(DateTime f)
        {
            Gastos[] tmp = null;
            if (gas == null)
            {
                return tmp;
            }

            foreach (Gastos p in gas)
            {
                if (p.Fecha.CompareTo(f) <= 0)
                {
                    AddGasto(p, ref tmp);
                }
            }

            return tmp;
        }
        public Ingresos[] BuscarPorFechaIngresos(DateTime f)
        {
            Ingresos[] tmp = null;
            if (ing == null)
            {
                return tmp;
            }

            foreach (Ingresos p in ing)
            {
                if (p.Fecha.CompareTo(f) <= 0)
                {
                    AddIngreso(p, ref tmp);
                }
            }

            return tmp;
        }

        public Gastos[] BuscarPorEnumGasto(EnumGastos x)
        {
            Gastos[] tmp = null;
            if (gas == null)
            {
                return tmp;
            }

            foreach (Gastos p in gas)
            {
                if (p.enumGasto == x)
                {
                    AddGasto(p, ref tmp);
                }
            }

            return tmp;
        }
        public Ingresos[] BuscarPorEnumIngreso(EnumIngreso x)
        {
            Ingresos[] tmp = null;
            if (ing == null)
            {
                return tmp;
            }

            foreach (Ingresos p in ing)
            {
                if (p.enumIngreso == x)
                {
                    AddIngreso(p, ref tmp);
                }
            }

            return tmp;
        }

        public Gastos[] BuscarPorRangoDePrecioGastos(decimal a, decimal z)
        {
            Gastos[] tmp = null;
            if (gas == null)
            {
                return tmp;
            }

            foreach (Gastos p in gas)
            {
                if (p.Cantidad >= a && p.Cantidad <= z)
                {
                    AddGasto(p, ref tmp);
                }
            }

            return tmp;
        }
        public Ingresos[] BuscaraPorRangoDePrecioIngresos(decimal a, decimal z)
        {
            Ingresos[] tmp = null;
            if (ing == null)
            {
                return tmp;
            }

            foreach (Ingresos p in ing)
            {
                if (p.Cantidad >= a && p.Cantidad <= z)
                {
                    AddIngreso(p, ref tmp);
                }
            }

            return tmp;
        }

        public string GetProductosAsJsonDeIngresos()
        {
            return JsonConvert.SerializeObject(ing);
        }
        public string getProductosAsJsonGastos()
        {
            return JsonConvert.SerializeObject(gas);
        }

        public int GetLastIngresoId()
        {
            return ing == null ? 0 : ing[ing.Length - 1].Id;
        }
        public int GetLastGastosId()
        {
            return gas == null ? 0 : gas[gas.Length - 1].Id;
        }

        #endregion

        #region Privados
        //Privados
        private void AddGasto(Gastos p, ref Gastos[] pds)
        {
            if (pds == null)
            {
                pds = new Gastos[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Gastos[] tmp = new Gastos[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }
        private void AddIngreso(Ingresos p, ref Ingresos[] pds)
        {
            if (pds == null)
            {
                pds = new Ingresos[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Ingresos[] tmp = new Ingresos[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }

        private int GetIndexByIdIngresos(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero.");
            }

            int index = int.MinValue, i = 0;
            if (ing == null)
            {
                return index;
            }

            foreach (Ingresos p in ing)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }
        private int GetIndexByIdGastos(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero.");
            }

            int index = int.MinValue, i = 0;
            if (gas == null)
            {
                return index;
            }

            foreach (Gastos p in gas)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }

      










        #endregion




    }
}
