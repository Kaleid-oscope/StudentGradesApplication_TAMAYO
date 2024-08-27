using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesApplication_TAMAYO
{
    internal class frmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.WriteLine("---------Grades----------");
            Console.Write("English: "); double english = Convert.ToDouble(Console.ReadLine());
            Console.Write("Math: "); double math = Convert.ToDouble(Console.ReadLine());
            Console.Write("Science: "); double science = Convert.ToDouble(Console.ReadLine());
            Console.Write("Filipino: "); double filipino = Convert.ToDouble(Console.ReadLine());
            Console.Write("History: "); double history = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double sum = english + math + science + filipino + history;
            double average = sum / 5;
            
            Console.Write("Generate your Average? Y/N: ");
            String choice = Console.ReadLine();
            Console.WriteLine(" ");
            if (choice == "Y" || choice == "y")
            {
                if (average > 75)
                {
                    Console.WriteLine("Student " + name + " passed!");
                    Console.WriteLine("Your average is: " + average);
                    Console.WriteLine("---------End----------");
                }
                else
                {
                    Console.WriteLine("Student " + name + " failed!");
                    Console.WriteLine("Your average is: " + average);
                    Console.WriteLine("---------End----------");
                }
            }
            else
            {
                Console.WriteLine("---------End----------");
            }
        }
    }
}
