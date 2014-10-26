using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProRandomAdjectiveClause
{
	public class ProRandomAdjectiveClause
	{
		string language;
		int repeat;

		Dictionary<string, Dictionary<string, string[]>> words = new Dictionary<string, Dictionary<string, string[]>> {
			{
				"tr", 
				new Dictionary<string, string[]>
				{
					{"names", 
						new string[] 
						{   
							"abajur",
							"agartici",
							"aski",
							"ayakkabı bağı",
							"balon",
							"balta",
							"bavul",
							"bayrak",
							"beyzbol",
							"bicak",
							"bicak",
							"civi",
							"dantel",
							"duvar",
							"el arabası",
							"fare",
							"fatura",
							"fermuar",
							"fotograf albumu",
							"goz",
							"gozluk",
							"hoparlör",
							"igne",
							"inci",
							"iplik",
							"izgara",
							"jel",
							"kagit",
							"kahve makinesi",
							"kutu",
							"ok",
							"ors",
							"outlet",
							"pasaport",
							"pastel boya",
							"piyano",
							"radyo",
							"resim cercevesi",
							"ruj",
							"saat",
							"sabun",
							"sapka",
							"sueter",
							"sünger",
							"zincir",
							"zımba",
							"zımpara",
							"çiş",
							"çorap",
							"şeker",

						}
					},
					{"adjectives", 
						new string[] 
						{ 
							"antika",
							"büyük",
							"büyük",
							"büyük",
							"cılız",
							"cılız",
							"dar",
							"derin",
							"dev",
							"devasa",
							"dik",
							"dikenli",
							"donuk",
							"düz",
							"düz",
							"düz",
							"fantezi",
							"garip",
							"geniş",
							"geniş",
							"grotesk",
							"güzel",
							"harika",
							"hasarlı",
							"inişli çıkışlı",
							"içi boş",
							"kavisli",
							"kaygan",
							"kirli",
							"kocaman",
							"koyu",
							"kuru",
							"küçük",
							"küçük",
							"zarif",
							"çamurlu",
							"çarpık",
							"çekici",
							"çirkin",
							"şişman"

						}
					}
				}
			},

			{
				"en", 
				new Dictionary<string, string[]>
				{
					{"names", 
						new string[] 
						{ 
							"anvil",
							"arrow",
							"axe",
							"balloon",
							"baseball",
							"bathtub",
							"bible",
							"bike",
							"bikini",
							"bleach",
							"blouse",
							"blowdryer",
							"book",
							"bookmark",
							"boombox",
							"bottle cap",
							"button",
							"candle",
							"candy wrapper",
							"canvas",
							"clock",
							"coffee maker",
							"comb",
							"cookie jar",
							"cork",
							"crayons",
							"credit card",
							"cushion",
							"deodorant",
							"detergent",
							"seatbelt",
							"sharpie",
							"shield",
							"shoelace",
							"shovel",
							"tobacco",
							"toothpaste",
							"toothpick",
							"vase",
							"wheelbarrow",
							"whiteout",
							"zipper",
						}
					},

					{"adjectives", 
						new string[] 
						{  
							"attractive",
							"average",
							"beautiful",
							"big",
							"broad",
							"broken",
							"bumpy",
							"chubby",
							"clean",
							"colorful",
							"colossal",
							"fancy",
							"fat",
							"filthy",
							"flat",
							"gigantic",
							"gorgeous",
							"graceful",
							"great",
							"grotesque",
							"high",
							"hollow",
							"huge",
							"large",
							"little",
							"long",
							"mammoth",
							"massive",
							"miniature",
							"misty",
							"muddy",
							"narrow",
							"petite",
							"plain",
							"precious",
							"prickly",
							"puny",
							"quaint",
							"round",
							"scrawny",
							"shallow",
							"shiny",
							"short",
							"skinny",
							"tiny",
							"ugly",
							"unusual",
							"wide"
						}
					}
				}
			}
		};

		public ProRandomAdjectiveClause(string arglang, int argrpt)
		{
			this.language = arglang;
			this.repeat = argrpt;
			//	Generate ();
		}

		public void Generate()
		{
			int lengthOfNameList = this.words[this.language]["names"].Length;
			int lengthOfAdjectiveList = this.words[this.language]["adjectives"].Length;

			Random rand = new Random();

			string clause = this.words [this.language] ["adjectives"] [rand.Next (lengthOfAdjectiveList)] + " " + this.words [this.language] ["names"] [rand.Next (lengthOfNameList)];
		
			for (int i = 1; i <= this.repeat; i++) 
			{

				if (History(clause) == 1 )
				{
					Console.WriteLine (clause);
					File.WriteAllText(@"history.txt", clause);
				}
				else
				{
					continue;
				}

			}
		}

		public int History(string product)
		{
			foreach (string line in File.ReadAllLines("history.txt"))
			{
				if (product == line)
				{
					return 0;
				}
				else 
				{
					return 1;
				}
			}
			return 1;
		}


	}
}