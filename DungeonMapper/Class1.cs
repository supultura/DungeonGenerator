﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonGenerator;

namespace DungeonMapper
{
	class PrintDungeon
	{
		public static void Main()
		{
			Piece[][] Map = CreateDungeon.DungeonSetup(60, 60);
			Map = CreateDungeon.DungeonFill(Map);
			CreateDungeon.PrintDung(Map);
		}
	}
}
