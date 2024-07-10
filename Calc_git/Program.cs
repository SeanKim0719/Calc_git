// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;

class Program
{
    int a, b;
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.display();
        Console.WriteLine("git");
        calc.CalcMulti(1,2);
    }
}

class Calculator
{
    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }
    public int CalcMulti(int num1, int num2)
    {
        return num1 * num2;
    }
}