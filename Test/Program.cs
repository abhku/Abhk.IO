﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abhk.IO;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = Input.NextInt();
			double b = Input.NextDouble();
			decimal c = Input.NextDecimal();
			string d = Input.GetNextWord();
			Console.WriteLine("{0},{1},{2},{3}",a,b,c,d);
			Input.GetNextChar();
		}
	}
}
