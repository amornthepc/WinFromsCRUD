using EmployeeLibrary.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ConfigureService();

            var employeeEntry = ServiceProvider.GetRequiredService<EmployeeEntry>();

            Application.Run(employeeEntry);
        }

        public static void ConfigureService()
        {
            var service = new ServiceCollection();
            service.AddTransient<EmployeeEntry>();
            service.AddTransient<AddEmployeeForm>();
            service.AddTransient<UpdateEmployeeForm>();
            service.AddTransient<ISqlDataAccess, SqlDataAccess>();
            service.AddTransient<IEmployeeData, EmployeeData>();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();
            service.AddSingleton(config);

            ServiceProvider = service.BuildServiceProvider();

        }
    }
}