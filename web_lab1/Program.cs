using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using web_lab1.Entities;
using web_lab1.Services;

namespace web_lab1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // DI set up
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((ctx, services) =>
                {
                    ConfigureServices(ctx.Configuration, services);
                })
                .Build();
            var services = host.Services;
            var mainForm = services.GetRequiredService<FormSagesList>();

            Application.Run(mainForm);
        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            // Entity framework database context
            services.AddDbContext<DatabaseContext>();

            // Main form
            services.AddSingleton<FormSagesList>();

            services.AddSingleton<BookService>();

            services.AddSingleton<SageService>();

            // TODO provide services
            // // Transient Services
            // services.AddTransient<IBusinessLayerClass1, BusinessLayerClass1>();
            //
            // // Singleton Services
            // services.AddSingleton<IBusinessLayerClass2, BusinessLayerClass2>();

            // TODO provide modals if exists
            // Other forms
            // services.AddTransient<ChildForm1>();
        }
    }
}