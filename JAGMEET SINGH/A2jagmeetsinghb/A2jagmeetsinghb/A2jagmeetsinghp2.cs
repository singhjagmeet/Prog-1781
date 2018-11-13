using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2jagmeetsinghb
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, d;
            Console.WriteLine("student's age");
            string ag = Console.ReadLine();
            double age = double.Parse(ag);
            Console.WriteLine("international student(yes,no)");
            string a = Console.ReadLine();
            Console.WriteLine("resgistration semester(fall,winter,summer)");
            string b = Console.ReadLine();

            if(a=="no")
            {
                if(age<=18)
                {
                    c = 300 + (0.13 * 300);
                    Console.WriteLine("base tuition $" + c);
                }
                else if (age <=49)
                {
                    c = 300 + (0.13 * 300);
                    Console.WriteLine("base tuition $" + c);
                }
                else
                {
                    c = 400 + (0.13 + 400);
                    Console.WriteLine("base tuition $" + c);
                }
            }
            else if(a=="yes")
            {
                if(age<=18)
                {
                    c = 400 + (0.13 + 400);
                    Console.WriteLine("international student fee" + c);
                }
                if (age <= 49)
                {
                    c = 600 + (0.13 + 600);
                    Console.WriteLine("international student fee" + c);
                }
                else
                {
                    c = 500 + (0.13 + 500);
                    Console.WriteLine("international student fee" + c);
                }
            }
            switch(b)
            {
                case "fall":
                    {
                        d = 250 + (0.13 + 250);
                        Console.WriteLine("registration fee for semester $" + d);
                        double tax = 250 * 0.13;
                        Console.WriteLine("hst $" + tax);
                        double total = d + tax;
                        Console.WriteLine("total:" + total);
                        break;
                    }
                case "winter":
                    {
                        d = 220 + (0.13 + 220);
                        Console.WriteLine("registration fee for semester $" + d);
                        double tax = 220 * 0.13;
                        Console.WriteLine("hst $" + tax);
                        double total = d + tax;
                        Console.WriteLine("total:" + total);
                        break;
                    }
                case "summer":
                    {
                        d = 150 + (0.13 + 150);
                        Console.WriteLine("registration fee for semester $" + d);
                        double tax = 150 * 0.13;
                        Console.WriteLine("hst $" + tax);
                        double total = d + tax;
                        Console.WriteLine("total:" + total);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("enter volid month");
                        break;
                    }
            }
        }
    }
}
