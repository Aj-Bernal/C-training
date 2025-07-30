using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of table: ");
            int table = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)    
            {
                Console.WriteLine(table * i);    
            }
        }
    }
}
