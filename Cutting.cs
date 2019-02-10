using System;

namespace Cnc
{
	public class Cutting
	{
		public static string[] getGCode(decimal L, decimal W, decimal H, bool two, bool DirectW, decimal Podrez, decimal S)
		{	

			Console.WriteLine("L=" + L.ToString());
			Console.WriteLine("W=" + W.ToString());
		
			char l = DirectW? 'X':'Y';
			char w = DirectW? 'Y':'X';
			return new string[] {
				"G17 G21 G40 G54 G80 G90",				
				"F400",
				"G00 Z" + (H+5).ToString(),
				"G00 " + l + (L-S).ToString() + " " + w + W.ToString(),
				"M3",
				two? "G01 Z" + (H-Podrez).ToString(): "",
				two? "G01 " + w + "0":"",
				two? "G00 Z" + (H+5).ToString():"",
				two? "G00 " + w + W.ToString():"",
				"G00 Z0",
				"G01 " + w + "0",
				"M5",
				"G00 Z" + (H+5).ToString(),
				"M2"
			};
		}
	}
}
