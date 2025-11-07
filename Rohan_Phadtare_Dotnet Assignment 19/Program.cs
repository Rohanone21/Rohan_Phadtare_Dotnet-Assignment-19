using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rohan_Phadtare_Dotnet_Assignment_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            // Create thread instances
            Thread numberThread = new Thread(PrintNumbers);
            Thread alphabetThread = new Thread(PrintAlphabets);

            // Set thread names for identification
            numberThread.Name = "Thread 1";
            alphabetThread.Name = "Thread 2";

            // Start the threads
            numberThread.Start();
            alphabetThread.Start();

            // Wait for both threads to complete
            numberThread.Join();
            alphabetThread.Join();

            Console.WriteLine("Main Thread Completed");
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[{Thread.CurrentThread.Name}] Number: {i}");
                Thread.Sleep(500); // Simulate some work
            }
        }

        static void PrintAlphabets()
        {
            char[] alphabets = { 'A', 'B', 'C', 'D', 'E' };

            foreach (char letter in alphabets)
            {
                Console.WriteLine($"[{Thread.CurrentThread.Name}] Alphabet: {letter}");
                Thread.Sleep(500); // Simulate some work
            }
        }
    }
}
