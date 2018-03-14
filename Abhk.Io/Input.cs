using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abhk.IO
{
	public static class Input
	{
		public static char GetNextChar()
		{
			return (char)Console.Read();
		}
		public static string GetNextWord()
		{
			bool reachedEnd = false, inputStarted = false;
			int newChar;
			StringBuilder result = new StringBuilder();

			while (!reachedEnd)
			{
				newChar = Console.Read();

				if (newChar == -1)
				{
					reachedEnd = true;
				}
				else
				{
					if (char.IsWhiteSpace((char)newChar) && inputStarted)
					{
						reachedEnd = true;
						// 13 is \r
						if (newChar == 13 && Environment.NewLine == "\r\n")
						{
							// carriage return is followed by \n in windows. extra read to utilize it
							Console.Read();
						}
					}
					else
					{
						inputStarted = true;
						result.Append((char)newChar);
					}
				}
			}

			return result.ToString();
		}
		public static string GetNextLine()
		{
			return Console.ReadLine();
		}
		public static int NextInt()
		{
			string s = GetNextWord();
			return int.Parse(s);
		}

		public static double NextDouble()
		{
			string s = GetNextWord();
			return double.Parse(s);
		}

		public static decimal NextDecimal()
		{
			string s = GetNextWord();
			return decimal.Parse(s);
		}

	}
}
