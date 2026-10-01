using System;
using Leason2;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HMath calc = new HMath();

            Console.WriteLine("калькулятор ");
            Console.WriteLine("Доступные операции: +, -, *, /");
            

            Console.Write("первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите действие (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write(" второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            bool isCorrect = true; 
            switch (operation)
            {
                case "+":
                    result = calc.Sum(a, b);
                    break;
                case "-":
                    result = calc.Subtract(a, b);
                    break;
                case "*":
                    result = calc.Multiply(a, b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка");
                        isCorrect = false;
                    }
                    else
                    {
                        result = calc.Divide(a, b);
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    isCorrect = false;
                    break;
            }

            if (isCorrect)
            {
                Console.WriteLine($"Результат: {a} {operation} {b} = {result}");
            }
        }
    }
}