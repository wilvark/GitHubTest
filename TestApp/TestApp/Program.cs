﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // I am changing the code to commit a change to git and make a comment about the checkin.  
            // This is more changes
            RadMethood("This is the text!");
        }

        private static void RadMethood(string text)
        {
            Console.Write(text);
            Console.WriteLine(".....");
            var input = Console.ReadLine();
        }
    }
}
