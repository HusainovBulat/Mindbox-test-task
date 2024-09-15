using FiguresLibrary.Figure;

namespace FiguresLibrary.Test
{
	public class TriangleTests
	{
		[Test]
		[TestCase(3, 3, 3, 3.897114317029974)]
		[TestCase(2, 3, 4, 2.9047375096555625)]
		[TestCase(1, 2, 3, 0)]
		public void GetArea_WithDifferentBaseValues_ShouldReturnCorrectResult(double sideA, double sideB, double sideC, double expectedResult)
		{
			// Arrange
			Triangle triangleObj = new Triangle(sideA, sideB, sideC);

			// Act
			double result = triangleObj.GetArea();

			// Assert
			Assert.That(expectedResult == result);
		}

		[Test]
		[TestCase(1, 2, 4)]
		[TestCase(2, 3, 6)]
		[TestCase(-1, 2, 3)]
		public void GetArea_WithDifferentBaseValues_ShouldReturnException(double sideA, double sideB, double sideC)
		{
			// Assert
			Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
		}
	}
}