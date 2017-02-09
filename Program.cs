using System;
using System.Linq;

namespace DistanceBetweenPoint
{
	public class MainClass
	{
		public static void Main()
		{
			var firstPoint = Console.ReadLine()
									.Split(' ')
			                        .Select(double.Parse)
			                        .ToArray();

			var secondPoint = Console.ReadLine()
									 .Split(' ')
			                         .Select(double.Parse)
									 .ToArray();

			var first = new Point
			{
				X = firstPoint[0],
				Y = firstPoint[1]
			};

			var second = new Point
			{
				X = secondPoint[0],
				Y = secondPoint[1]
			};

			var result = CalculateDist(first, second);

			Console.WriteLine($"{result:F3}");

		}

		public static double CalculateDist(Point firstP, Point secondP)
		{
			var calcX = firstP.X - secondP.X;
			var calcY = firstP.Y - secondP.Y;

			var powX = Math.Pow(calcX, 2);
			var PowY = Math.Pow(calcY, 2);

			return Math.Sqrt(powX + PowY);
		}
	}
}
