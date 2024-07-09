// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.display();
        Console.WriteLine("git");
        calc.func_mult();
    }
}

class Calculator
{
    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }
    public void func_mult()
    {
        Console.WriteLine("Multi is booting");
    }
}