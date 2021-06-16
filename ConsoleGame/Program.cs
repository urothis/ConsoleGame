﻿using System;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ButtNekid's Bounce House");
            Console.Write("What's your name:");

            var name = Console.ReadLine();

            Console.WriteLine("You awake in a cold stone, dark room. You feel dazed and are having trouble remembering anything about your past.");

            if (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("You don't even know your own name.");
            }
            else
            {
                Console.WriteLine($"You know your name is {name}.");
            }

            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance as\nyou turn the handle, but the rusty lock breaks with little effort. You see your captor\nstanding with his back to you outside the door.");
        }
    }
}
