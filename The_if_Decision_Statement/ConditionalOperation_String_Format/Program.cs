﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.ComponentModel.DataAnnotations;

namespace Variables
{
    class ConditionalOperation_String_Format
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            // Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered:{0}, therefore you won a {1}.",userValue, message);
            Console.ReadLine();
        }
    }
}