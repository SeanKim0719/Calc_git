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

//the Four Fundamental Arithmetic Operations
interface FFAO
{
    int Add(int num1, int num2);
    int Sub(int num1, int num2);
    int Mul(int num1, int num2);
    int Div(int num1, int num2);

}

class Calculator: FFAO
{
    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }

    int FFAO.Add(int num1, int num2)
    {
        return num1 + num2;
    }
    int FFAO.Sub(int num1, int num2)
    {
        return num1 - num2;
    }
    int FFAO.Mul(int num1, int num2)
    {
        return num1 * num2;
    }
    int FFAO.Div(int num1, int num2)
    {
        try
        {
            return num1 / num2;
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("0으로는 나눌 수 없습니다.");
            return 0;
        }
    }
}