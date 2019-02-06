using System;
using System.Collections;
using System.Globalization;

namespace Cnc
{
	public class Turning
	{	
		private static float strToFloat(string s)
		{
			return Convert.ToSingle(s, new CultureInfo("en-US"));
		}

		private static float[] prepareCode(string[] Lines, out string[] outCode) 
		{
			float[] maxXY = new float[2] {0,0};
			float v;
			string[] str;
			string outStr;
			ArrayList code = new ArrayList();
			
			foreach(string line in Lines)
			{
				str = line.Split(' ');
				
				if(str[0] == "M5") 
				{
					break;
				} 
				else 
				{
					
					if(str[0] == "G00" || str[0] == "G01" || str[0] == "G02" || str[0] == "G03") 
					{		
						outStr = "";
						foreach(string s in str) 
						{
							if(s != "") 
							{
								if(s[0] == 'X') 
								{							
									try 
									{
										v = strToFloat(s.Substring(1));
									} 
									catch 
									{
										v = 0;
									}
									if( v > maxXY[0] )
										maxXY[0] = v;
								} 
								else
									if(s[0] == 'Y') 
								{
									try 
									{
										v = strToFloat(s.Substring(1));
									} 
									catch 
									{
										v = 0;
									}
									if( v > maxXY[1] )
										maxXY[1] = v;
								}
								if(s[0] != 'Z')
									outStr += " " + s;
							}
						}
						if(outStr != "") 
							code.Add((str[0] == "G00"? "G01":str[0]) +  outStr);
					}
				}
			}
			Console.WriteLine(maxXY[0].ToString() + ':' + maxXY[1].ToString());
			outCode = code.ToArray(typeof(string)) as string[];
			return maxXY;
		}

		private static string preparePathLine(string line, float curYDecr) 
		{
			if(curYDecr == 0)
				return line;

			string[] str = line.Split(' ');
			float y;

			for(int i = 0; i < str.Length; i++) 
			{
				if(str[i][0] == 'Y') 
				{
					y = strToFloat(str[i].Substring(1));
					str[i] = "Y" + (y - curYDecr).ToString();
				}
			}
			return string.Join(" ", str);
		}

		public static string[] getGCode(string[] Lines, decimal D, decimal MaxDepth)
		{	
			ArrayList code = new ArrayList();

			double delta = Math.Sqrt((double)(D*D)/2) - (double)D / 2;
			string[] pathCode;
			float[] maxXY = prepareCode(Lines, out pathCode);
			float maxD = (float)MaxDepth;
			float Length = maxXY[0];
			float curXDir = Length;	
			float curYDecr = 0;
			float maxY = maxXY[1];
						
			code.Add("G17 G21 G40 G54 G80 G90");
			code.Add("M3");
			code.Add("F400");

			code.Add("G00 Y" + delta);

			// cylindering
			while(delta > 0) 
			{
				if(delta <=  maxD) 
				{
					code.Add("G01 Y" + delta.ToString());
				} 
				else 
				{
					code.Add("G01 Y" + maxD.ToString());
				}
				delta -= maxD;
				code.Add("G01 X" + curXDir.ToString());
				curXDir = curXDir == 0? Length:0;			
			}
			
			code.Add("G00 X0");
			
			while( maxY>0 ) 
			{
				if(maxY > (float)MaxDepth) 
				{
					curYDecr = maxY - (float)MaxDepth;
					maxY -= (float)MaxDepth;
				} 
				else 
				{
					curYDecr = 0;
					maxY = 0;
				}
				foreach(string line in pathCode) 
				{
					code.Add(preparePathLine(line, curYDecr));
				}
			}
					
			code.Add("M5");
			code.Add("G00 Y-150");
			code.Add("G00 X0");
			code.Add("M2");

			return code.ToArray(typeof(string)) as string[];
		}
	}
}
