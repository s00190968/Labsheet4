using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemon
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int num = 0;

            School[] AllSchools = new School[5];

            Console.WriteLine("Enter data for five schools.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + ". Enter school's name:");
                name = Console.ReadLine();

                Console.WriteLine("Enter the amount of students enrolled.");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Enter the amount of students enrolled.");
                }

                AllSchools[i] = new School(name, num);
            }

            displaySchools(AllSchools);

            Array.Sort(AllSchools);

            displaySchools(AllSchools);

        }

        public static void displaySchools(School[] arr)
        {
            Console.WriteLine(" All schools:\n");
            foreach (School s in arr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
