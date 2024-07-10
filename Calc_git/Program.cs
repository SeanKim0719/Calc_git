// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;
using Calc_git_memory;

class Program
{
    int a, b;
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
    }
}

//the Four Fundamental Arithmetic Operations
interface FFAO
{
    public int Add(int num1, int num2);
    public int Sub(int num1, int num2);
    public int Mul(int num1, int num2);
    public int Div(int num1, int num2);
}

class Calculator: FFAO
{
    CalcMemory memory = new CalcMemory();
    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }

    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        memory.SAVE(result);
        return result;
    }
    public int Sub(int num1, int num2)
    {
        int result = num1 - num2;
        memory.SAVE(result);
        return result;
    }
    public int Mul(int num1, int num2)
    {
        int result = num1 * num2;
        memory.SAVE(result);
        return result;
    }
    public int Div(int num1, int num2)
    {
        int result = num1 / num2;
        memory.SAVE(result);
        return num1 / num2;
    }
}