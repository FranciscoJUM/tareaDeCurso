using Autofac;
using Cortina.Interfces;
using Cortina.Servicios;
using Dominio.Interfaces;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarteraDigital
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CarteraModel>().As<IMetodos>();
            builder.RegisterType<CarteraService>().As<ICarteraService>();
          
           
            var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GestorDeGastos(container.Resolve<ICarteraService>()));
        }
    }
}
