using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex2
{
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

