using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeworkVer._2
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mad Lib Lab!!\n");
            Console.Title = ("<======= MAD LIB =======>");

            // Create a "mad Lib" that asks the user for various pieces of information. Store the information as strings. Once the information has been collected, ouput a story using the stored information.
            //Example Reference:
            //InputLab.cs class in _4Thursday receiving input

            Console.WriteLine("Please enter some information below to do a Mad Lib...: \n");

            Console.WriteLine("Enter a proper noun here:");
            string properNoun = Console.ReadLine();
            Console.WriteLine("Enter a verb with an -ing here:");
            string verbIng = Console.ReadLine();
            Console.WriteLine("Enter a noun here:");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Enter a pronoun here:");
            string pronoun1 = Console.ReadLine();
            Console.WriteLine("Enter another noun here:");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Enter another pronoun here:");
            string pronoun2 = Console.ReadLine();
            Console.WriteLine("And finally, please enter another verb here:");
            string verb = Console.ReadLine();
            
            Console.WriteLine($"One day {properNoun} was {verbIng} to the {noun1}. On the way, {pronoun1} saw a {noun2}. This was a surprise so {pronoun2} {verb} quickly.");
        }
    }
}
