﻿using System;

namespace Snake
{
    class HorizontalLine : Figure
	{
		public HorizontalLine(int xLeft, int xRight, int yCord, char symb)
		{
			for (int xCord = xLeft; xCord <= xRight; xCord++)
			{
				Point point = new(xCord, yCord, symb);
				PointsList.Add(point);
			}
		}

		public override void DrawObject()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			base.DrawObject();

			Console.ForegroundColor = ConsoleColor.White;
		}
	}
} 