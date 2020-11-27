using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			if ((r1.Left >= r2.Left - r1.Width) && (r1.Left <= r2.Left + r2.Width))
				if ((r1.Top <= r2.Top + r2.Height) && (r1.Top + r1.Height >= r2.Top))
					return true;
			return false;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			var x = Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left);
			var y = Math.Max(r1.Top, r2.Top) - Math.Min(r1.Bottom, r2.Bottom);
			if (AreIntersected(r1, r2))
				return Math.Abs(x * y);
			return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (r1.Left <= r2.Left && r1.Top <= r2.Top && r1.Right >= r2.Right && r1.Bottom >= r2.Bottom)
				return 1;
			if (r2.Left <= r1.Left && r2.Top <= r1.Top && r2.Right >= r1.Right && r2.Bottom >= r1.Bottom)
				return 0;
			return -1;
		}
	}
}
