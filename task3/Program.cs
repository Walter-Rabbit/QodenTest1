using System.Linq;
using System;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new Stack<int>();
            
            int left;
            int right;
            Console.ReadLine()
                .Split(new char[] { ' ' })
                .ToList()
                .ForEach(token =>
                {
                    switch (token)
                    {
                        case "+":
                            right = numbers.Pop();
                            left = numbers.Pop();
                            numbers.Push(left + right);
                            break;
                        case "-":
                            right = numbers.Pop();
                            left = numbers.Pop();
                            numbers.Push(left - right);
                            break;
                        case "*":
                            right = numbers.Pop();
                            left = numbers.Pop();
                            numbers.Push(left * right);
                            break;
                        case "/":
                            right = numbers.Pop();
                            left = numbers.Pop();
                            numbers.Push(left / right);
                            break;
                        default:
                            numbers.Push(Convert.ToInt32(token));
                            break;
                    }
                });
            
            Console.WriteLine(numbers.Pop());
        }
    }
}