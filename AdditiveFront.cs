using System;
using System.Collections;

namespace Cnc
{
	public class AdditiveFront
	{		
		public static string[] getGCode(string[] L, decimal W, decimal X, bool noX, decimal Count, decimal Depth, int t)
		{	
			ArrayList code = new ArrayList();
			float dist = (float)W / (float)(Count + 1); // the distance between holes
			float currentPos = 0;
			float xx = (float)X;
			decimal D;
			int i;
			
			code.Add("G17 G21 G40 G54 G80 G90");
			code.Add("M3");
			code.Add("F400");
			
			code.Add("G00 Z5");
			foreach(string line in L) 
			{
				currentPos = noX? xx:0;

				code.Add("G00 X" + line);

				for(i = 0; i < Count; i++) 
				{
					currentPos += dist;
					if(
						t == 1 || t == 2 || 
						(t == 3 && i != 2 && i != (Count - 2)) || 
						(t == 4 && (i == 2 || i == (Count - 2)))
						) 
					{
						D = Depth;
						
						code.Add("G00 Y" + currentPos.ToString());
						code.Add("G01 Z" + D.ToString());
						code.Add("G00 Z-5");
					}
				}	
			}
			
			code.Add("M5");
			code.Add("G00 Z5");
			code.Add("G00 X0 Y0");
			code.Add("M2");

			return code.ToArray(typeof(string)) as string[];
		}
	}
}
