using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("請輸入身高(公尺):");
            string height = Console.ReadLine();

            Console.Write("請輸入體重(公斤)");
            string weight = Console.ReadLine();

            double total = double.Parse(weight) / (double.Parse(height) * double.Parse(height));
            Console.WriteLine("您的BMI值為:" + total);

            if(18.5 <= total && total < 24)
            {
                Console.WriteLine("您的體重正常");
            }
            else if (total >= 24)
            {
                Console.WriteLine("您的體重過重了");
            }
            else
            {
                Console.WriteLine("您的體重過輕了");
            }

            Console.ReadLine();
        }
    }
}
