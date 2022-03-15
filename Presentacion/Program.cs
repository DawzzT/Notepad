using AppCore.Services;
using AppCore.IServices;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Repository;
using Presentacion.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
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

            //builder.RegisterType<TasksListRepository>().As<ITaskRepository>();
            builder.RegisterType<DirectoryRepository>().As<IDirectory>();
            builder.RegisterType<DirectoryServices>().As<IDirectoryServices>();
            Application.EnableVisualStyles();
            var container = builder.Build();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Notepad(container.Resolve<IDirectoryServices>()));
        }
    }
}
