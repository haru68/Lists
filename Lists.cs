using System;
using System.Collections.Generic;

namespace Listes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> StringList = new List<string>(new string[]{"Hello world", "I am coding for SXB", "in WCS school" });

            StringList.Add("in socks");
            StringList.Add("with the cool attitude");
            StringList.Add("At the fifth floor");

            foreach (string element in StringList)
            {
                Console.WriteLine(element);
            }

            StringList.RemoveAt(0);

            StringList.Remove("in socks");

            StringList[1] = "Spy intrusion";

            Console.WriteLine();
            foreach (string element in StringList)
            {
                Console.WriteLine(element);
            }



        }
    }
}
