namespace FiguresLibrary
{
	public interface ITriangle : IFigureArea
	{
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }

		public bool IsTriangleRight();
	}
}