﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator a = new Calculator();
            //Console.WriteLine($"3 opløftet i 4. er {a.Power(3,4)}");

            Console.WriteLine($"Nemt {a.Accumulator + a.Add(1, 2)}");
            
            a.Clear();
            Console.WriteLine($"{a.Accumulator}");
            

            Console.WriteLine($"Nemt {a.Add(2)}");

            Console.WriteLine($"Nemt {a.Add(2)}");
        }
    }
}
