using Microsoft.Extensions.DependencyInjection;
using POO_TaxCalc.Domain.Infrastructure;
using POO_TaxCalc.Domain.Interfaces;
using POO_TaxCalc.Interface;
using POO_TaxCalc.Presentation.Screens;
using POO_TaxCalc.Presentation.Screens.Interface;
using POO_TaxCalc.Services;
using POO_TaxCalc.Services.Interface;

namespace POO_TaxCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var salaryScreen = serviceProvider.GetService<ICalculationFlow>();
            salaryScreen.Start();

        }


        private static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<ITaxCalculator, TaxCalculator>()
                .AddScoped<IScreen, Screen>()
                .AddScoped<ITaxTableRepository, TaxTableRepository>()
                .AddScoped<ICalculationFlow, CalculationFlow>();
        }
    }
}