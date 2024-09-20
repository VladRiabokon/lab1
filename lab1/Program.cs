using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first
            string name = "Рябоконь Владислав";
            int age = 17;
            Console.WriteLine("Привiт, мене звати {0}, менi {1} рокiв", name, age);
            // end

            //task 2
            int a = 3;
            int b = 7;
            double result;
            result = ((Math.Pow(a - b, 3) - Math.Pow(a, 3)) / (Math.Pow(b, 3) - 3 * a * Math.Pow(b, 2) - 3 * Math.Pow(a, 2) * b)); Console.WriteLine("task2");
            Console.WriteLine($"result = {result}");
            Console.ReadKey();
            //end

            //tusk 3
            Console.WriteLine("Виведення трьохзначного числа в зворотному порядку:");
            int input, output;
            input = Convert.ToInt32(Console.ReadLine());
            output = (input % 10 * 100 + (input % 100 / 10 * 10) + (input / 100));
            Console.WriteLine($"{input} --> {output}");
            Console.ReadKey();
            //end

        }
    }
}
