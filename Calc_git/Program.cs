// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.display();
        Console.WriteLine("git");
    }
}

class Calculator
{
    
    public int CalcAdd(int num1, int num2)
    {
        return num1 + num2; 
    }

    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }
}