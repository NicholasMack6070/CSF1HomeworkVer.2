using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeworkVer._2
{
    class FruitLoops2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops 2");
            Console.WriteLine();
            Console.Title = ("<=======FRUIT LOOPS 2 =======>");

            string[] fruits = { "grapes", "oranges", "bananas", "grapefruits", "kiwi", "rasberries" };
            string[] period = { ".", "..", "...", "....", ".....", "......" };
            Console.WriteLine("Here are " + fruits.Length + " differnt types of fruits:\n");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < period.Length; i++)
            {
                Console.WriteLine(fruits[i] + period[i]);
            }
        }
    }
}
