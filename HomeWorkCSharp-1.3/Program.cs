using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.3.Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».            
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + value);
        }
    }
}
