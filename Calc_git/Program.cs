// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;

class Program
{
    int a, b;
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
    }
}

class Calculator
{
    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }
}