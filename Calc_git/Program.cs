﻿// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.display();
        Console.WriteLine("feature");
    }
}

class Calculator
{
    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }
}