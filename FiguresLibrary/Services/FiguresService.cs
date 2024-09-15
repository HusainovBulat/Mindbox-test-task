using System.Runtime.CompilerServices;

using FiguresLibrary.Figure;

[assembly: InternalsVisibleTo("FiguresLibrary.Test")]
namespace FiguresLibrary.Services
{
	internal class FiguresService : IFiguresService
	{
		public ITriangle GetTriangle(double sideA, double sideB, double sideC)
			=> new Triangle(sideA, sideB, sideC);
	}
}