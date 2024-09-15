using FiguresLibrary;
using FiguresLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceProviderExtensions
{
	public static void AddAreaAndFiguresServices(this IServiceCollection services)
	{
		services.AddTransient<IAreaCalculationService, AreaCalculationService>();
		services.AddTransient<IFiguresService, FiguresService>();
	}
}