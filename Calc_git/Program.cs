// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;
using Calc_git_memory;
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

    public void Result(int result)
    {
        Console.Write("연산 결과는" + result + "입니다.");
    }
}