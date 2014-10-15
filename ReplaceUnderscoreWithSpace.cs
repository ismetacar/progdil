using System;

namespace UnderScoreToSpace
{
	class UnderScoreToSpace
	{
		/* ReplaceUnderscoreWithSpace fonksiyonu argüman olarak gelen stringi 
		   önce karakter dizisine çeviriyor, ardından bu dizi elemanları üzerinde
		   dolaşarak (dizinin ilk ve son elemanı hariç) '_' karakterini ' ' (space)
		   olarak güncelliyor. */
		static void ReplaceUnderscoreWithSpace(string a)
		{
			char[] array = a.ToCharArray();
			for (int i = 1; i < array.Length-1; i++)
				if (array[i] == '_')  array[i] = ' ';

			string s = new string(array);

			System.Console.WriteLine(s);
			
		}
		/* Main fonksiyonu bir argüman listesi alıyor. Bu argüman listesi String türünde. 
		   Yine main fonksiyonu bu listenin ilk elemanından başlayarak ReplaceUnderscoreWithSpace
		   fonksiyonuna tabii tutuyor. */
		static void Main(String[] args)
		{
			for(int i = 0; i < args.Length; i++)
			{
				ReplaceUnderscoreWithSpace(args[i]); 
			}
		}
	} 
}
			
