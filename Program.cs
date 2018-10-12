using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex2
{ /*
    Тип данных представляется классом с необходимыми полями, 
    а операции реализуются как внешние функции, 
    которые получают объекты данного типа в качестве аргументов;

    Комплексное число представляется парой действительных чисел (a, b), где а – действительная часть, b – мнимая часть. Реализовать класс Complex для работы с комплексными числами. Обязательно должны присутствовать операции:

    - сложения add, (a, b) + (c, d) = (a + с, b + d);

    - вычитания sub, (a, b) – (c, d) = (a – c, b - d);

    - умножения mul, (a, b) * (c, d) = (ac – bd, ad + bc);

    - деления div, (a, b) / (c, d) = (ac + bd, bc - ad) / (c2 + d2);

    - сравнение equ, (a, b) = (c, d), если (a = c) и (b = d);

    - сопряженное число conj, conj(a, b) = (a, -b)
    */
    class Complex
    {
        public double a, b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Variables();
            
        }
        static void Variables()
        {
            Complex complexNum = new Complex();

            Init(ref complexNum);
            Display(complexNum);
            while (true)
            {
                Console.Write("What do you want to do next? You have a variables options: sum, sub, mul, div, equ, conj, exit. ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "sum":
                        Console.WriteLine(Sum(complexNum));
                        break;
                    case "sub":
                        Console.WriteLine(Sub(complexNum));
                        break;
                    case "div":
                        Console.WriteLine(Div(complexNum));
                        break;
                    case "mul":
                        Console.WriteLine(Mul(complexNum));
                        break;
                    case "equ":
                        Console.WriteLine(Equ(complexNum));
                        break;
                    case "conj":
                        Console.WriteLine(Conj(complexNum));
                        break;
                }
                if (answer == "exit")
                    break;
            }

        }
        public static void Init(ref Complex num)
        {
            Console.Write("Put in a real part:");
            num.a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part: ");
            num.b = Convert.ToDouble(Console.ReadLine());
        }
        public static void Display(Complex num)
        {
            Console.WriteLine("Your complex number is {0}+{1}i", num.a, num.b);
        }
        public static string ToString(double realPart, double imaginaryPart)
        {
            string rslt = Convert.ToString(realPart) + "+" + Convert.ToString(imaginaryPart) + "i";
            return rslt;
        }
        public static string Sum(Complex num)
        {
            Complex num2 = new Complex();
            Init(ref num2);
            double realPart = num.a + num2.a;
            double imaginaryPart = num.b + num2.b;
            string rslt = "Sum is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public static string Mul(Complex num)
        {
            Complex num2 = new Complex();
            Init(ref num2);
            double realPart = (num.a * num2.a) - (num.b * num2.b);
            double imaginaryPart = num.a * num2.a + num.b * num2.b;
            string rslt = "Mul is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public static string Sub(Complex num)
        {
            Complex num2 = new Complex();
            Init(ref num2);
            double realPart = num.a - num2.a;
            double imaginaryPart = num.b - num2.a;
            string rslt = "Sub is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public static string Div(Complex num)
        {
            Complex num2 = new Complex();
            Init(ref num2);
            double realPart = (num.a *num2.a + num.b * num2.b) / (num.a * num2.a + num.b * num2.b);
            double imaginaryPart = (num.b * num2.a - num.a * num2.b) / (num.a * num.a + num2.b * num2.b);
            string rslt = "Div is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public static string Equ(Complex num)
        {
            Complex num2 = new Complex();
            Init(ref num2);
            return (num.a == num2.a && num.b == num2.b) ? "They are equal" : "They are not equal";
        }
        public static string Conj(Complex num)
        {
            Complex num2 = new Complex();
            Init(ref num2);
            return (num.a == num2.a && num.b == -num2.b) ? "They are conjugate" : "They are not conjugate";
        }
    }
}

