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

            Console.WriteLine("Enter a noun here:");
            string noun = Console.ReadLine();
            Console.WriteLine("Enter a verb here:");
            string verb = Console.ReadLine();
            Console.WriteLine("Enter an adverb here:");
            string adverb = Console.ReadLine();
            //add more info
            //make a creative sentence...
            //too tired.......
            Console.WriteLine($"There once was a {noun} that had a. ");
        }
    }
}
