using System;
using System.Collections;
using System.Globalization;

namespace Cnc
{
	public class Holes
	{
		private static float strToFloat(string s)
		{
			return Convert.ToSingle(s, new CultureInfo("en-US"));
		}

		private static string[] prepareLine(string line, float Depth) 
		{
			string[] str = line.Split(' ');
            int L = 0;
			float X = strToFloat(str[0]);
            float Y = strToFloat(str[1]);
			float I = 0;
		    float J = 0;
			float D = Depth;
			foreach(string s in str) 
			{
				if(s[0] == 'L')
					L = Int32.Parse(s.Substring(1));
				else
				if(s[0] == 'I')
					I = strToFloat(s.Substring(1));
				else
				if(s[0] == 'J')
					J = strToFloat(s.Substring(1));
				else
				if(s[0] == 'D')
					D = strToFloat(s.Substring(1));
			}

			if(L == 0) 
			{
				return new string[] {
										"G81 X" +X.ToString()+ " Y" +Y.ToString()+ " Z-" + D.ToString() + " R5 F300"
									};
			} 
			else 
			{
				ArrayList code = new ArrayList();
				for(int i = 0; i<L; i++) 
				{
					code.Add("G81 X" +X.ToString()+ " Y" +Y.ToString()+ " Z-" + D.ToString() + " R5 F300");
					X = X + I;
					Y = Y + J;
				}
				return code.ToArray(typeof(string)) as string[];
			}

		}

		public static string[] getGCode(string[] Data, string Depth)
		{	
			ArrayList code = new ArrayList();
			float D = strToFloat(Depth);
			string[] str;
			
			code.Add("G17 G21 G40 G54 G80 G90");
			
			code.Add("G00 Z5");
			code.Add("M3");
			code.Add("F400");
			
			foreach(string line in Data) 
			{
				str = prepareLine(line, D);
				foreach(string s in str) 
				{
					code.Add(s);
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
