// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int first_input, second_input;
        Calculator calc = new Calculator();
        InterFace interFace = new InterFace();
        first_input = interFace.Get_number_first();
        second_input = interFace.Get_number_second();
    }
}

class Calculator
{
    public void display()
    {
        Console.WriteLine("Calculate is booting");
    }
}

class InterFace
{
    string input;
    enum Operator { plus = 1, minus = 2, multi = 3, divide = 4};
    public int Get_number_first()
    {
        {
            Console.WriteLine("첫번째 숫자를 입력해주세요 >> ");
            input = Console.ReadLine();
            return int.Parse(input);
        }
    }
    public int Get_number_second() 
    {
         {
              Console.WriteLine("두번째 숫자를 입력해주세요 >> ");
              input = Console.ReadLine();
              return int.Parse(input);
         }
    }
    public int operation()
    {
        int choice;
        Console.WriteLine("원하는 연산을 선택하세요");
        Console.WriteLine("1.더하기 2.빼기 3.곱하기 4.나누기");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }
}