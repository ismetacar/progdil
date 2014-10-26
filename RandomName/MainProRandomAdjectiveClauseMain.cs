using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProRandomAdjectiveClause
{
	public class ProRandomMain
	{
		public static void Main(String[] args)
		{

			string language = "tr";
			int repeat = 1;

			if (args.Length == 2) 
			{
				if ((args [0] == "en" | args [0] == "tr") & int.TryParse (args [1], out repeat)) 
				{
					language = args [0];
				} 
				else if (args [1] == "en" | args [1] == "tr" & int.TryParse (args [0], out repeat)) 
				{
					language = args [1];
				} 
				else 
				{
					help ();
				}
			} 
			else if (args.Length == 1) 
			{
				if(args [0] == "en" | args [0] == "tr") 
				{
					language = args [0];
				} 
				else if (int.TryParse (args [0], out repeat)) 
				{
					//automaticaly doing
				}
				else if (args[0] == "help" | args[0] == "-h")
				{
					help ();
				}
				else
				{
					help ();
				}
			} 

			else if (args.Length == 0) 
			{
				//nothing
			}

			else {
				help ();
			}

			ProRandomAdjectiveClause clause = new ProRandomAdjectiveClause (language, repeat);

			clause.Generate ();

		}
		public static void help ()
		{
			Console.WriteLine("\t\t\tKullanım kılavuzu\n");
			Console.WriteLine("NAME");
			Console.WriteLine("\t\t MainProRandomAdjectiveClause.exe");
			Console.WriteLine("SYNOPSIS");
			Console.WriteLine("\t\t $mono MainProRandomAdjectiveClause.exe [-lang] [-num] [-h or help]");
			Console.WriteLine("OPTION");
			Console.WriteLine("\t\t -lang:");
			Console.WriteLine("\t\t\t The choice of language. tr[Turkish] and en[English] supported languages");
			Console.WriteLine("\t\t -num:");
			Console.WriteLine("\t\t\t Number of repetitions. This argument must be integers");
			Console.WriteLine("\t\t -h or help:");
			Console.WriteLine("\t\t\t Directs you to the user manual. This page =) ");
			Console.WriteLine("EXAMPLE");
			Console.WriteLine("\t\t\t $mono MainProRandomAdjectiveClause.exe en 10");
			Console.WriteLine("\t\t\t $mono MainProRandomAdjectiveClause.exe tr 10");
			Console.WriteLine("\t\t\t $mono MainProRandomAdjectiveClause.exe 10");
			Console.WriteLine("\t\t\t $mono MainProRandomAdjectiveClause.exe help");
			Console.WriteLine("\t\t\t $mono MainProRandomAdjectiveClause.exe -h");
			Console.WriteLine ("Not: Kullanıma uygun olmayan çalıştırma şeklinde dil ön tanımlı Türkçe olarak dikkate alınacaktır..\n");
		}
	}
}
