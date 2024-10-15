using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama (Decimal) = ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka kedua (Whole) = ");
            int input2 =  Convert.ToInt32(Console.ReadLine());

            double sum = input1 + input2;
            double sub = input1 - input2;
            double mult = input1 * input2;
            double div = input1 / input2;

            Console.WriteLine($"{input1} + {input2} = {sum}");
            Console.WriteLine($"{input1} - {input2} = {sub}");
            Console.WriteLine($"{input1} x {input2} = {mult}");
            Console.WriteLine($"{input1} / {input2} = {div}");

            


        }
    }
}