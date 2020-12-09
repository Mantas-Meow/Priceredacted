using Priceredacted.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Priceredacted.Interfaces;
using Priceredacted.Processors;

namespace Priceredacted
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
                Application.Run(mainWindow);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddScoped<IMainWindowController, MainWindowController>();
        }
    }
}
