using FiguresLibrary.Figure;

namespace FiguresLibrary.Test
{
	public class CircleTests
	{
		[Test]
		[TestCase(1, 3.1415926535897931)]
		[TestCase(1.1, 3.8013271108436504)]
		[TestCase(15, 706.85834705770344)]
		public void GetArea_WithDifferentBaseValues_ShouldReturnCorrectResult(double radius, double expectedResult)
		{
			// Arrange
			Circle circleObj = new Circle(radius);

			// Act
			double result = circleObj.GetArea();

			// Assert
			Assert.That(expectedResult == result);
		}

		[Test]
		[TestCase(0)]
		[TestCase(-5)]
		public void GetArea_WithDifferentBaseValues_ShouldReturnException(double radius)
		{
			// Assert
			Assert.Throws<ArgumentException>(() => new Circle(radius));
		}
	}
}