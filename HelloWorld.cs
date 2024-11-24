using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* These are variables.
              They contain data values. */
            int NumberA = 3;

            // Same type of variables
            char CharA = 'a', CharB = 'b', CharC = 'c';
            Console.WriteLine(CharA + "" + CharB + "" + CharC); // idk why or how but it just put numbers if i dont put ""

            // Same value for variables
            double DoubleA, DoubleB, DoubleC;
            DoubleA = DoubleB = DoubleC = 0.5;
            Console.WriteLine(DoubleA + DoubleB + DoubleC);

            // WriteLine codes
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000); //This thing is delay in 1 seconds
            Console.WriteLine("Testing, testing.");
            Thread.Sleep(1000);

            // Write + WriteLine codes
            Console.Write("Among ");
            Console.WriteLine("Us");
            Thread.Sleep(1000);

            // Write codes
            Console.Write("2 + 2 is ");
            Thread.Sleep(1000);
            Console.Write(2 + 2);
            Thread.Sleep(1000);

            Console.WriteLine(" minus 1 is " + NumberA);
            Thread.Sleep(1000);
            Console.WriteLine("Quick maths");
            Thread.Sleep(1000);

            // This overrides 3
            NumberA = 28;
            Console.WriteLine(NumberA + " apples eaten by a man. I wonder who.");

            // const prevents NumberB to be overriden
            const int NumberB = 9;
            Console.WriteLine(NumberB + " lives for the cat.");

            // Convertion example
            double DoubleD = 5.5;
            int NumberC = (int)DoubleD;
            Console.WriteLine("This is a double: " + DoubleD);
            Console.WriteLine("This is an integer: " + NumberC);

            // User iput using Console.ReadLine()
            Console.WriteLine("Oh yeah, I haven't gotten your name yet. What is it?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello there, " + Name);

            // If-else statement
            Console.WriteLine("Have you seen the man who ate some apples, " + Name + "? (Y/N)");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(""); // Here just to make the rest write on the other line

            if (key.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Keep an eye out for them.");
            }
            else if (key.Key == ConsoleKey.N)
            {
                Console.WriteLine("Heard they came from a python repository called 'HelloWorld-Python'. Keep an eye out for them.");
            }
            else
            {
                Console.WriteLine("Sorry? I didn't understand. Just keep an eye out for them.");
            }

            Thread.Sleep(1000);
            Console.WriteLine("Objection!");
            Thread.Sleep(1000);
            Console.WriteLine("This man here ate the apple, and I have proof.");
            Thread.Sleep(1000);

            String CorrectAns = "n";
            while (CorrectAns != "A")
            {
                Console.WriteLine("The evidence that shows this is...");
                Console.WriteLine("A. HelloWorld-Python");
                Console.WriteLine("B. HelloWorld-Java");
                Console.WriteLine("C. HelloWorld-VisualBasic");
                Console.WriteLine("D. HelloWorld-CSharp");
                CorrectAns = Console.ReadLine();

                if (CorrectAns != "A") 
                {
                    Console.WriteLine("No, thats not it...");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine("Take that!");
            Thread.Sleep(1000);
            Console.WriteLine("Have a look at the repository called 'HelloWorld-Python.'");
            Thread.Sleep(1000);
            Console.WriteLine("It looks pretty sus.");
            Thread.Sleep(1000);
            Console.WriteLine("But there's more to it than that.");
            Thread.Sleep(1000);
            Console.WriteLine("Take a look at the fingerprints.");
            Thread.Sleep(1000);
            Console.WriteLine("Yes, I am pertaining to YOUR finger prints.");
            Thread.Sleep(1000);
            Console.Write("How 'bout that, Mr. Sawhit ");
            Thread.Sleep(1000);
            Console.Write("or should I say ");
            Thread.Sleep(1000);
            Console.WriteLine("MR DID IT");
            Thread.Sleep(1000);
            Console.WriteLine(Name + ": Objection!");
            Thread.Sleep(1000);
            Console.WriteLine(Name + ": You can't get fingerprints in repositories... can you?");
            Thread.Sleep(1000);
        }
    }
}