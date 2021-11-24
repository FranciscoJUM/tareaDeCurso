using Cortina.Interfces;
using Dominio.Entidades;
using Dominio.Enums;
using Infraestructura;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarteraDigital
{
    public partial class GestorDeGastos : Form
    {
        public ICarteraService ser { get; set; }
      
        public GestorDeGastos( ICarteraService ser)
        {
            this.ser = ser;
            InitializeComponent();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void CrearIngreso_Click(object sender, EventArgs e)
        {
           
            decimal cantidad = (decimal)NumIngreso.Value;
            string descripcion = TextIngreso.Text;
            EnumIngreso egg = (EnumIngreso)ComboIngreso.SelectedIndex;
            DateTime fecha = FechaIngreso.SelectionStart;


            if (descripcion == "" || cantidad == 0) { MessageBox.Show("Deben estar llenos todos los parametros llenos" ); }
            else
            {

                Ingresos x = new Ingresos()
                {
                    Id = ser.GetLastIngresoId()+1,
                    Cantidad = cantidad,
                    enumIngreso = egg,
                    Descripcion = descripcion,
                    Fecha = fecha,
                };
                ser.crearIngresos(x);
                Limpiar();

                MessageBox.Show(" Guardado correctamente");
                RichIngreso.Text = $"Id: {x.Id}, Cantidad: {x.Cantidad}, Origen: {x.enumIngreso}, Descripcion: {x.Descripcion}, Fecha: {x.Fecha}";
            }
                               

        }

        private void CrearGasto_Click(object sender, EventArgs e)
        {
            
            decimal cantidad = (decimal)NumGasto.Value;
            string descripcion = TextGasto.Text;
            EnumGastos Egas = (EnumGastos)ComboGasto.SelectedIndex;
            DateTime fecha = CalendarioGasto.SelectionStart;

            if (descripcion == "" || cantidad == 0) { MessageBox.Show("Todos los espacios deben ser llenados"); }
            else
            {

                Gastos x = new Gastos()
                {
                    Id = ser.GetLastGastosId()+1,
                    Cantidad = cantidad,
                    enumGasto = Egas,
                    Descripcion = descripcion,
                    Fecha = fecha,
                };
                ser.crearGastos(x);
                Limpiar();

                MessageBox.Show(" Guardado correctamente");
                RichGasto.Text = $"Id: {x.Id}, Cantidad: {x.Cantidad}, Origen: {x.enumGasto}, Descripcion: {x.Descripcion}, Fecha: {x.Fecha}";


            }

        }

        private void GestorDeGastos_Load(object sender, EventArgs e)
        {

            ComboGasto.Items.AddRange(Enum.GetValues(typeof(EnumGastos))
                                             .Cast<object>()
                                             .ToArray()
                                         );
            ComboIngreso.Items.AddRange(Enum.GetValues(typeof(EnumIngreso))
                                           .Cast<object>()
                                           .ToArray()
                                       );
            // bolsa 
            combobusquedagastos.Items.AddRange(Enum.GetValues(typeof(EnumGastos))
                                            .Cast<object>()
                                            .ToArray()
                                        );
            CombobusquedaIngreso.Items.AddRange(Enum.GetValues(typeof(EnumIngreso))
                                         .Cast<object>()
                                         .ToArray()
                                     );
            //fin
            if (ser.Findall() == null) { RichIngreso.Text = "vacio"; }
            if (ser.FindAll() == null) { RichGasto.Text = "Vacio"; }

            //iniciar combos
            combobusquedagastos.SelectedIndex = 0;
            CombobusquedaIngreso.SelectedIndex = 0;
            ComboIngreso.SelectedIndex = 0;
            ComboGasto.SelectedIndex = 0;
            numMinimo.Value = 1;
            numMaximo.Value = 1;
            NumIngreso.Value = 1;
            NumGasto.Value = 1;

        }
      

        private void button1_Click(object sender, EventArgs e)
        {

            if (ser.BuscaraPorRangoDePrecioIngresos(numMinimo.Value, numMaximo.Value) == null) { RichIngreso.Text = "No se encontro coincidencias"; }
            else
            {

                Ingresos[] a = ser.BuscaraPorRangoDePrecioIngresos(numMinimo.Value, numMaximo.Value);
                RichIngreso.Text = JsonConvert.SerializeObject(a);
            }

            //RichIngreso.Text = ser.BuscaraPorRangoDePrecioIngresos(numMinimo.Value, numMaximo.Value).ToString(); }



           



            if (ser.BuscarPorRangoDePrecioGastos(numMinimo.Value, numMaximo.Value) == null) { RichGasto.Text = "No se encontro"; }
            else
            {
                Gastos[] a = ser.BuscarPorRangoDePrecioGastos(numMinimo.Value, numMaximo.Value);
                RichGasto.Text = JsonConvert.SerializeObject(a);


                //RichGasto.Text = ser.BuscarPorRangoDePrecioGastos(numMinimo.Value, numMaximo.Value).ToString(); }
            }
        }

        private void Limpiar()
        {
            RichGasto.Text = "";
            RichIngreso.Text = "";
            RichBusqueda.Text = "";
            numMaximo.Value = 0;
            numMinimo.Value = 0;
            combobusquedagastos.SelectedIndex = 0;
            CombobusquedaIngreso.SelectedIndex = 0;

            NumIngreso.Value = 0;
            TextIngreso.Text = "";
            ComboIngreso.SelectedIndex = 0;

            NumGasto.Value = 0;
            TextGasto.Text = "";
            ComboGasto.SelectedIndex = 0;

        }
        #region f
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void TextGasto_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumGasto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CalendarioGasto_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ComboGasto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ComboIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FechaIngreso_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TextIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void ged(object sender, EventArgs e)
        {

        }

        private void MostrarTodo_Click(object sender, EventArgs e)
        {
            if (ser.GetProductosAsJsonDeIngresos() == null) { RichIngreso.Text = "Actuelmente no hay registro"; } else { RichIngreso.Text = ser.GetProductosAsJsonDeIngresos().ToString(); }
            if (ser.getProductosAsJsonGastos() == null) { RichGasto.Text = "Actuelmente no hay registro"; } else { RichGasto.Text = ser.getProductosAsJsonGastos().ToString(); }
            // if (ser.FindAll() == null) { RichGasto.Text = "Actualmente no hay registros"; }else { RichGasto.Text = ser.FindAll().ToString(); }
            // if (ser.Findall() == null) { RichIngreso.Text = "Actualmente no hay registros"; } else { RichIngreso.Text = ser.Findall().ToString(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EnumIngreso x = (EnumIngreso)CombobusquedaIngreso.SelectedIndex;
          
            
            if (ser.BuscarPorEnumIngreso(x) == null) { RichIngreso.Text = "No exixte ingreso en esta categoria"; } 
            else { Ingresos[] a = ser.BuscarPorEnumIngreso(x);
               RichBusqueda.Text=  JsonConvert.SerializeObject(a);

            }


            if (ser.BuscarPorEnumIngreso(x) == null) { RichBusqueda.Text = "No exixte ingreso en esta categoria"; }
            else
            {
                Ingresos[] a = ser.BuscarPorEnumIngreso(x);
                RichBusqueda.Text = JsonConvert.SerializeObject(a);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnumGastos x = (EnumGastos)CombobusquedaIngreso.SelectedIndex;

            if (ser.BuscarPorEnumGasto(x) == null) { RichGasto.Text = "No exixte ingreso en esta categoria"; }
            else
            {
                Gastos[] a = ser.BuscarPorEnumGasto(x);
                RichBusqueda.Text = JsonConvert.SerializeObject(a);

            }


            if (ser.BuscarPorEnumGasto(x) == null) { RichBusqueda.Text = "No exixte ingreso en esta categoria"; }
            else
            {
                Gastos[] a = ser.BuscarPorEnumGasto(x);
                RichBusqueda.Text = JsonConvert.SerializeObject(a);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RichGasto.Text = "";
            RichIngreso.Text = "";
            RichBusqueda.Text = "";
            numMaximo.Value = 1;
            numMinimo.Value = 1;
            combobusquedagastos.SelectedIndex = 0;
            CombobusquedaIngreso.SelectedIndex = 0;

            NumIngreso.Value = 1;
            TextIngreso.Text = "";
            ComboIngreso.SelectedIndex = 0;

            NumGasto.Value = 1;
            TextGasto.Text = "";
            ComboGasto.SelectedIndex = 0;

            
        }

        private void Suspender_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
