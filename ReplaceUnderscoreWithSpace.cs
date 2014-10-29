// Selam ismet, bu bir pull-req için hazırlıktır.
using System;

namespace UnderScoreToSpace
{
	static class UnderScoreToSpace
	{
		public static void ReplaceUnderscoreWithSpace(this string a)
		{
			char[] array = a.ToCharArray();
			int i, j, k;

			//iki for döngüsünü fonksiyona al
			for (i = 0; i < array.Length; i++)
			{
				if (array[i] != '_')
				{
					break;
				}
			}

			for (j = array.Length-1; j >= 0; j--)
			{
				if (array[j] != '_')
				{
					break;
				}
			}
			
			for (k = i; k < j; k++)
				array[k] = (array[k] == '_') ? ' ' : array[k];  //?  conditional operator

			string s = new string(array);

			System.Console.WriteLine(s);
			
		}
		static void Main(String[] args)
		{
			foreach (string element in args)
			{
				element.ReplaceUnderscoreWithSpace();     //patching active 
			}
		}
	} 
}
			
