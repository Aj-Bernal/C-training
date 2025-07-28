using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = -100D / 3D;

            Console.WriteLine(number);
            Console.WriteLine(string.Format("{0:0.00}", number));

            double money = 100D / 3D;

            Console.WriteLine(string.Format("{0:0.00}", money));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-PH")));
        }
    }
}
