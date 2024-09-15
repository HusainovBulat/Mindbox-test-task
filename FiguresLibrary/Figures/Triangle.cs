using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FiguresLibrary.Test")]
namespace FiguresLibrary.Figure
{
	internal class Triangle : ITriangle
	{
		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA > sideB + sideC
				|| sideB > sideA + sideC
				|| sideC > sideA + sideB)
			{
				throw new ArgumentException("For any triangle the sum of the lengths of any two sides" +
				" must be greater than or equal to the length of the remaining side");
			}

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }

		public double GetArea()
		{
			double p = (SideA + SideB + SideC) / 2;
			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}

		public bool IsTriangleRight()
		{
			double bigSide = SideA;
			double smallSide1 = SideB;
			double smallSide2 = SideC;

			if(bigSide < smallSide1)
			{
				(bigSide, smallSide1) = (smallSide1, bigSide);
			}
			if (bigSide < smallSide2)
			{
				(bigSide, smallSide2) = (smallSide2, bigSide);
			}

			return Math.Pow(bigSide, 2) == Math.Pow(smallSide1, 2) + Math.Pow(smallSide2, 2);
		}
	}
}