using CalculoIR.Services;
using CalculoIR.Services.Interfaces;
using CalculoIR.Presentation;
using Microsoft.Extensions.DependencyInjection;
using CalculoIR.Presentation.Interfaces;

namespace CalculoIR.Presentation;

public class Program
{
    public static void Main()
    {
        ServiceCollection service = new();
        ConfigureServices(service);

        var serviceProvider = service.BuildServiceProvider();
        var mainFlow = serviceProvider.GetService<IProgramFlow>();

        mainFlow.Begin();

    }
    public static void ConfigureServices(IServiceCollection service)
    {
        service
            .AddScoped<ITaxCalculator, TaxCalculator>()
            .AddScoped<IScreenPresentations, ScreenPresentations>()
            .AddScoped<IRegisterInput, RegisterInput>()
            .AddScoped<IProgramFlow, ProgramFlow>();

    }
}