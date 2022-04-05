using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeworkVer._2
{
    class FruitLoops1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops 1");
            Console.WriteLine();
            Console.Title = ("<=======FRUIT LOOPS 1 =======>");

            string[] fruits = { "grapes", "oranges", "bananas", "grapefruits", "kiwi", "rasberries" };
            Console.WriteLine("Here are " + fruits.Length + " differnt types of fruits:\n");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine();
        }
    }
}
