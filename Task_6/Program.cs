using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько скристалов вы хотите купить ?");
            int cristal = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько у Вас золота ?");
            int gold = int.Parse(Console.ReadLine());

            int priceForCristal = 13;
            gold -= priceForCristal * cristal;

            Console.WriteLine($"Вы купили {cristal} кристалов и у вас осталось {gold} золота");
        }
    }
}
