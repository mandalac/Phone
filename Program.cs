using System;
using phone.Models;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("Node 5", 100, "AT&T", "BIM BIM BAM");
            Nokia elevenHundred = new Nokia("1100", 80, "Verizon", "ZIN ZIN ZIN");

            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine("");

            elevenHundred.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine("");
        }
    }
}
