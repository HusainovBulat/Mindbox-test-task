using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FiguresLibrary.Test")]
namespace FiguresLibrary.Services
{
	internal class AreaCalculationService : IAreaCalculationService
	{
		public double GetArea(string FiguresName, object[] args)
		{
			Type? figureType = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(x => x.GetTypes())
				.FirstOrDefault
				(x =>
					x != typeof(IFigureArea)
					&& typeof(IFigureArea).IsAssignableFrom(x)
					&& x.Name.ToLower() == FiguresName.ToLower()
				);
			if (figureType == null)
			{
				throw new ArgumentException("Incorrect figure name");
			}

			if (figureType.GetConstructors().All(x => x.GetParameters().Length != args.Length))
			{
				throw new ArgumentException("Incorrect parameters count");
			}

			IFigureArea figure = (IFigureArea)Activator.CreateInstance(figureType, args);
			return figure.GetArea();
		}
	}
}