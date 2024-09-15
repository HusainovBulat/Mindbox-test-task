using Microsoft.Extensions.DependencyInjection;

using FiguresLibrary;

namespace Sample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ServiceCollection services = new ServiceCollection();
			services.AddAreaAndFiguresServices();

			var serviceProvider = services.BuildServiceProvider();

			Console.WriteLine($"Triangle:{serviceProvider.GetService<IAreaCalculationService>().GetArea("Triangle", [2d, 3d, 4d])}");
			Console.WriteLine($"Circle:{serviceProvider.GetService<IAreaCalculationService>().GetArea("Circle", [5d])}");
			Console.WriteLine();

			ITriangle triangle = serviceProvider.GetService<IFiguresService>().GetTriangle(7, 25, 24);
			Console.WriteLine($"Triangle({triangle.SideA},{triangle.SideB},{triangle.SideC})" +
			$" is {(triangle.IsTriangleRight() ? "" : "not ")}right");
			Console.ReadKey();
		}
	}
}