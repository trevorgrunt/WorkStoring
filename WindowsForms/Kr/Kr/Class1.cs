using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kr
{
    public static class Class1
    {
        public static void cf()
        {
            StreamWriter sw = new StreamWriter("D:\\Game_Industry.txt");
            sw.WriteLine("               Название игры | Год выпуска                 | Студия                      | Цена копии                  | Тираж                       | Стоимость разработки");
            //Write a second line of text          
            //Close the file
            sw.Close();
        }
        public static string cht()
        {
           return File.ReadAllText("D:\\Game_Industry.txt");
        }
        public static void wr(string name, int god, string studio, double price, int tir, int razr)
        {
            FileStream file1 = new FileStream("D:\\Game_Industry.txt", FileMode.Append); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком
            writer.WriteLine("{0,17}   |{1,17}   |{2,17}   |{3,17}   |{4,17}   |{5,17}", name, god, studio, price, tir, razr); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется
        }
        public static void rd() //Чтение на случай если будут проверять эту возможность
        {
            String line;
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("D:\\Game_Industry.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the lie to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
        }
        public static string rchst(string name, int god, string studio, double price, int tir, int razr)
        {
            int pribl;
            int max = Int32.MinValue;
            var cr = DateTime.Now.Year;
            for (int i = 1; i < 16; i++)
            {
                pribl = razr - ((cr - god) + (Convert.ToInt32(price) * tir));
                if (pribl > max)
                {
                    max = pribl;
                }
            }
            return name;
        }
    }
    public static class Class2
    {
        public static void Main()
        {
            List<Industry> arr = new List<Industry>
            {
                                    new Industry{name="Cyberpunk2077", god=2020, studio="CDPR", price = 60, tir = 13000000, razr = 320000000},
                                    new Industry{name="Witcher 3", god= 2014,studio="CDPR", price = 60, tir = 30000000, razr = 100000000},
                                    new Industry{name="Assassins Creed 2", god= 2010,studio="Ubisoft", price = 30, tir = 7000000, razr = 5000000},
                                    new Industry{name="Fallout New Vegas", god= 2010,studio="Bethesda", price = 30, tir = 3000000, razr = 50000000},
                                    new Industry{name="Portal 2", god=2011, studio="Valve", price = 15, tir = 4000000, razr = 8000000},
                                    new Industry{name="Crysis", god=2007, studio="EA", price = 30, tir = 2000000, razr = 10000000 },
                                    new Industry{name="The Walking Dead", god=2012, studio="Telltale", price = 20, tir = 7000000, razr = 15000000},
                                    new Industry{name="Overwatch", god=2016, studio="Blizzard", price = 60, tir = 10000000, razr = 15000000},
                                    new Industry{name="Valorant", god=2020, studio="Riot", price = 0, tir = 5000000, razr = 4000000},
                                    new Industry{name="CS GO", god=2012, studio="Valve", price = 0, tir = 20000000, razr = 7000000},
                                    new Industry{name="Dont Starve Together", god=2014, studio="Klei", price = 10, tir = 1000000, razr = 600000},
                                    new Industry{name="Hearts of Iron 4", god=2016, studio="Paradox", price = 10, tir = 800000, razr = 2000000 },
                                    new Industry{name="Victoria 2", god=2010, studio="Paradox", price = 5, tir = 300000, razr = 400000 },
                                    new Industry{name="Crusader Kings 3", god=2020, studio="Paradox", price = 60, tir = 1000000, razr = 5000000 },
                                    new Industry{name="Minecraft", god=2009, studio="Mojang", price = 0, tir = 100000000, razr = 1000000 },
                                    new Industry{name="World Of Tanks", god=2012, studio="Wargaming", price = 0, tir = 20000000, razr = 2500000 },
                                    new Industry{name="Dota 2", god= 2012,studio="Valve", price = 0, tir = 40000000, razr = 15000000 },
                                    new Industry{name="GTA 5", god= 2014,studio="Rockstar", price = 30, tir = 32000000, razr = 256000000  },
                                    new Industry{name="PUBG", god= 2017,studio="BlueHole", price = 20, tir = 11000000, razr = 3000000},
                                    new Industry{name="Stardew Valley", god=2016, studio="Chucklefish", price = 15, tir = 800000, razr = 170000 },
                                    new Industry{name="ATOM RPG", god=2018, studio="AtomTeam", price = 10, tir = 450000, razr = 100000 },
                                    new Industry{name="M&B Bannerlord", god=2020, studio="Paradox", price = 30, tir = 1000000, razr = 2000000 },
                                    new Industry{name="Warband", god=2010, studio="Paradox", price = 10, tir = 1300000, razr = 1500000 },
                                    new Industry{name="Skyrim", god=2012, studio="Bethesda", price = 20, tir = 24000000, razr = 10000000 },
                                    new Industry{name="Cities Skylines", god=2017, studio="Paradox", price = 20, tir = 3000000, razr = 2000000 },
                                    new Industry{name="Sims 4", god=2014, studio="EA", price = 60, tir = 6000000, razr = 4000000 },
                                    new Industry{name="Tropico 6", god=2019, studio="Kalypso", price = 60, tir = 8000000, razr = 2000000 },
                                    new Industry{name="Stalker", god=2007, studio="GSC", price = 30, tir = 11000000, razr = 250000 },
                                    new Industry{name="The Long Dark", god=2017, studio="Spectrum", price = 7, tir = 100000, razr = 50000},
                                    new Industry{name="Dayz", god=2018, studio="Bohemia", price = 30, tir = 18000000, razr = 7000000 }
            };
            FileStream file1 = new FileStream("D:\\Game_Industry.txt", FileMode.Append); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком
            var IndustryGroups = from Industry in arr
                              group Industry by Industry.name;
            foreach (IGrouping<string, Industry> g in IndustryGroups)
            {
                foreach (var t in g)
                    writer.WriteLine("{0,26}   |{1,26}   |{2,26}   |{3,26}   |{4,26}   |{5,26}", t.name, t.god, t.studio, t.price, t.tir, t.razr);
            }
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется
        }  
    }
    public class Industry
    {
        public string name { get; set; }
        public int god { get; set; }
        public string studio { get; set; }
        public int tir { get; set; }
        public int razr { get; set; }
        public int price { get; set; }       
    }


}
