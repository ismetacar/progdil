using System;

namespace UnderScoreToSpace
{
	class UnderScoreToSpace
	{
		static void ReplaceUnderscoreWithSpace(string a)
		{
			char[] array = a.ToCharArray();
			for (int i = 1; i < array.Length-1; i++ )
			{
				if (array[i] == '_')
				{
					array[i] = ' ';
				}
			}

			string s = new string(array);

			System.Console.WriteLine(s);
			
		}
		static void Main(String[] args)
		{
			for(int i = 0; i < args.Length; i++)
			{
				ReplaceUnderscoreWithSpace(args[i]); 
			}
		}
	} 
}
			
