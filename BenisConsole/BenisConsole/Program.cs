using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BenisConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы только что открыли приложение для взлома казино, вы уверены что хотите забрать у казино почти все его деньги? [y/n]");
            Console.ReadLine();
            Console.Write("Взлом:");
            string vzlom = "[..........]100%";
            for (int i = 0; i < vzlom.Length; i++)
            {
                Thread.Sleep(1000);
                Console.Write(vzlom[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Взлом завершён, получилось забрать: 1 200 000 рублей");
            Console.ReadLine();
        }
    }
}
