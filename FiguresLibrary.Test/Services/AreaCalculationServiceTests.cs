using FiguresLibrary.Services;

namespace FiguresLibrary.Test
{
	public class AreaCalculationServiceTests
	{
		AreaCalculationService _areaCalculationServiceTests;

		[SetUp]
		public void Setup()
		{
			_areaCalculationServiceTests = new AreaCalculationService();
		}

		#region Triangle
		[Test]
		[TestCase("triangle", 2, 3, 4, 2.9047375096555625)]
		[TestCase("TRIANGLE", 2, 3, 4, 2.9047375096555625)]
		[TestCase("Triangle", 3, 3, 3, 3.897114317029974)]
		[TestCase("tRIANGLE", 3, 3, 3, 3.897114317029974)]
		[TestCase("tRiAnGlE", 1, 2, 3, 0)]
		public void GetArea_WithDifferentBaseValues_ShouldReturnCorrectResult_Triangle(string figuresName, double sideA, double sideB, double sideC, double expectedResult)
		{
			// Act
			double result = _areaCalculationServiceTests.GetArea(figuresName, [sideA, sideB, sideC]);

			// Assert
			Assert.That(expectedResult == result);
		}

		[Test]
		[TestCase("triangl", new object[3] { 2, 3, 4 })]
		[TestCase("trianãle", new object[3] { 1, 2, 4 })]
		[TestCase("triangle", new object[2] { 2, 3 })]
		[TestCase("tRIANGLE", new object[2] { 3, 3 })]
		[TestCase("tRiAnGlE", new object[2] { 1, 2 })]
		[TestCase("triangle", new object[1] { 2 })]
		[TestCase("tRIANGLE", new object[1] { 3 })]
		[TestCase("tRiAnGlE", new object[1] { 1 })]
		public void GetArea_WithDifferentBaseValues_ShouldReturnException_Triangle(string figuresName, object[] args)
		{
			// Assert
			Assert.Throws<ArgumentException>(() => _areaCalculationServiceTests.GetArea(figuresName, args));
		}
		#endregion

		#region Circle
		[Test]
		[TestCase("circle", 2, 12.566370614359172)]
		[TestCase("CIRCLE", 3, 28.274333882308138)]
		[TestCase("Circle", 4, 50.26548245743669)]
		[TestCase("cIRCLE", 5, 78.53981633974483)]
		[TestCase("cIrClE", 1, Math.PI)]
		public void GetArea_WithDifferentBaseValues_ShouldReturnCorrectResult_Circle(string figuresName, double radius, double expectedResult)
		{
			// Act
			double result = _areaCalculationServiceTests.GetArea(figuresName, [radius]);

			// Assert
			Assert.That(expectedResult == result);
		}

		[Test]
		[TestCase("circl", new object[1] { 1 })]
		[TestCase("cèrcle", new object[1] { 2 })]
		[TestCase("triangle", new object[2] { 2, 3 })]
		[TestCase("tRIANGLE", new object[2] { 3, 3 })]
		[TestCase("tRiAnGlE", new object[2] { 1, 2 })]
		public void GetArea_WithDifferentBaseValues_ShouldReturnException_Circle(string figuresName, object[] args)
		{
			// Assert
			Assert.Throws<ArgumentException>(() => _areaCalculationServiceTests.GetArea(figuresName, args));
		}
		#endregion
	}
}