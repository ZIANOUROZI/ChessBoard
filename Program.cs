// Zia Nourozi.NET23
using System;
using System.Diagnostics.CodeAnalysis;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Mata in en siffra"); //asking user for a number
            int input = int.Parse(Console.ReadLine()); // convert the string provided by the user to integer 


            for (int row = 1; row <= input; row++) // this loop represents each row
            {
                for (int column = 1; column <= input; column++) //  this loop represents each column
                {
                    if ((row + column) % 2 == 0) // in a division by 2 see if there is remaining value of row + column
                    {
                        Console.Write("◼︎");
                    }
                    else
                    {
                        Console.Write("◻︎");
                    }
                   
                }
                Console.WriteLine();
            }





        }
    }
}

