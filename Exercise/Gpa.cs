using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gpa
{
    internal class Program
    {
        static void Main(string[] args)
        {
string studentName = "Sophia Johnson";
string courseName1 = "English 101";
string courseName2 = "Algebra 101";
string courseName3 = "Biology 101";
string courseName4 = "Computer Science I";
string courseName5 = "Pyschology 101";

int grade1 = 4;
int grade2 = 3;
int grade3 = 3;
int grade4 = 3;
int grade5 = 4;

int creditHours1 = 3;
int creditHours2 = 3;
int creditHours3 = 4;
int creditHours4 = 4;
int creditHours5 = 3;

int gradeValue1 = grade1 * creditHours1;
int gradeValue2 = grade2 * creditHours2;
int gradeValue3 = grade3 * creditHours3;
int gradeValue4 = grade4 * creditHours4;
int gradeValue5 = grade5 * creditHours5;

int gradeSum = gradeValue1 + gradeValue2 + gradeValue3 + gradeValue4 + gradeValue5;
int creditSum = creditHours1 + creditHours2 + creditHours3 + creditHours4 + creditHours5;

decimal Gpa = (decimal)gradeSum / creditSum;

int leadingDigit = (int) Gpa;
int firstDigit = (int) (Gpa * 10) % 10;
int secondDigit = (int) (Gpa * 100) % 10;

Console.WriteLine($"Student: " + studentName + "\n" );
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
Console.WriteLine(courseName1 + "\t\t\t" + grade1 + "\t\t" + creditHours1 );
Console.WriteLine(courseName2 + "\t\t\t" + grade2 + "\t\t" + creditHours2 );
Console.WriteLine(courseName3 + "\t\t\t" + grade3 + "\t\t" + creditHours3 );
Console.WriteLine(courseName4 + "\t" + grade4 + "\t\t" + creditHours4 );
Console.WriteLine(courseName5+ "\t\t" + grade5 + "\t\t" + creditHours5 + "\n");

Console.WriteLine($"Final GPA\t\t\t{leadingDigit}.{firstDigit}{secondDigit}" );
        }
    }
}
