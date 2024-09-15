using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FiguresLibrary.Test")]
namespace FiguresLibrary.Figure
{
	internal class Circle : IFigureArea
	{
		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException("the length of the radius of the circle must be greater than zero");
			}
			Radius = radius;
		}
		public double Radius { get; set; }

		public double GetArea() => Math.PI * Math.Pow(Radius, 2);
	}
}