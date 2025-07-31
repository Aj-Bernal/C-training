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
          int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value); // 2

value += 1;
Console.WriteLine("Second increment: " + value); // 3

value++;
Console.WriteLine("Third increment: " + value); // 4

value = value - 1;
Console.WriteLine("First decrement: " + value); // 3

value -= 1;
Console.WriteLine("Second decrement: " + value); // 2

value--;
Console.WriteLine("Third increment: " + value); //1
        }
    }
}  
      
