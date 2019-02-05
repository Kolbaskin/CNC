using System;
using System.Collections;

namespace Cnc
{
	public class AdditiveButt
	{		

		public static string[] getGCode(decimal W, decimal X, bool noX, decimal H, decimal Count, decimal Depth, int t, decimal t2Depth)
		{	
			ArrayList code = new ArrayList();
			float dist = (float)W / (float)(Count + 1); // the distance between holes
			float currentPos = 0;
			decimal D;

			if(noX)
				currentPos = (float)X;

			code.Add("G17 G21 G40 G54 G80 G90");
			code.Add("M3");
			code.Add("F400");

			code.Add("G00 X-5");
			code.Add("G00 Z" + (H/2).ToString());
			
			for(int i = 0; i < Count; i++) 
			{
				currentPos += dist;
				if(
					t == 1 || t == 2 || 
					(t == 3 && i != 2 && i != (Count - 2)) || 
					(t == 4 && (i == 2 || i == (Count - 2)))
				) 
				{
					if(t == 2 && (i == 2 || i == (Count - 2)))
						D = t2Depth;
					else
						D = Depth;
					
					code.Add("G00 Y" + currentPos.ToString());
					code.Add("G01 X" + D.ToString());
					code.Add("G00 X-5");
				}
			}	
			
			code.Add("M5");
			code.Add("G00 Y5");
			code.Add("G00 X0");
			code.Add("M2");

			return code.ToArray(typeof(string)) as string[];
		}
	}
}
