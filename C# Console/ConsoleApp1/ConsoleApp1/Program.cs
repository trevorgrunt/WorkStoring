using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static double fl1(string name, int god, string studio, double price, int tir, int razr) //Объявление функции на поиск длины 
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("C:\\Test.txt");
            //Write a line of text
            sw.WriteLine("Название игры | Год выпуска | Студия | Цена копии | Тираж | Стоимость разработки");
            //Write a second line of text
            sw.WriteLine("{0,10} | {1,10} | {0,10} | {1,10} | {0,10} | {1,10}", name, god, studio, price, tir, razr);
            //Close the file
            sw.Close();
            return 0;
        }
        static void Main(string[] args)
        {
            for (int x = 0; x < 10; x++)
            {
                string name = Console.ReadLine();
                int god = Convert.ToInt32(Console.ReadLine());
                string studio = Console.ReadLine();
                double price = Convert.ToDouble(Console.ReadLine());
                int tir = Convert.ToInt32(Console.ReadLine());
                int razr = Convert.ToInt32(Console.ReadLine());
                fl1(name, god, studio, price, tir, razr);
            }
        }
    }
}

