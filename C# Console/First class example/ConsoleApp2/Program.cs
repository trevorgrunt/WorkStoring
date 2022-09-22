using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Phone
    {
        public int number;
        public int weight;
        public string model;
        public string name;
        public void ReceiveCall()
        {
            Console.WriteLine($"Имя: {name}");
        }
        public void getNumber()
        {
           Console.WriteLine("Номер = "+number);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Номер: {number} Вес: {weight} Модель: {model}");           
        }
        public Phone() { name = "Неизвестно"; number = 0; weight = 0; model = "Неизвестно";}      

        public Phone(string n) { name = n; number = 0; weight = 0; model = "Неизвестно"; }         

        public Phone(string n, int a) { name = n; number = a; weight = 0; model = "Неизвестно"; }

        public Phone(string n, int a, int b) { name = n; number = a; weight = b; model = "Неизвестно"; }

        public Phone(string n, int a, int b, string c) { name = n; number = a; weight = b; model = c; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Phone tph1 = new Phone();
            Phone tph2 = new Phone("Телефон2", 15, 500, "Realmi");
            Phone tph3 = new Phone("Телефон3", 25);
            Phone tph4 = new Phone("Телефон4");
            Phone tph5 = new Phone("Телефон5", 12, 300);

            tph1.GetInfo();
            tph2.GetInfo();
            tph3.GetInfo();
            tph4.GetInfo();
            tph5.GetInfo();
            tph2.ReceiveCall();
            tph2.getNumber();
            Console.ReadKey();
        }
    }
}
