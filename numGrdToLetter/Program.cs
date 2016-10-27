using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numGrdToLetter
{
    class Program
    {
        static void Main(string[] args)


        {
            

            Console.WriteLine("Please Enter a numeric grade from 0 to 100 ");
            int numGrade = int.Parse(Console.ReadLine());
            char lettGrade =   numLetter(numGrade);
            Console.WriteLine("The Letter Grade for your number grade = " + lettGrade);
            Console.ReadLine();
            Console.WriteLine("Do you want to continue? Y/N");
            string input = Console.ReadLine();
            if (input == "N")
            {

                Console.WriteLine("Have a nice Day");
            }

        }
        public static char numLetter(int numGrade)
        {

            while (true)
            {
                if (numGrade >= 88 && numGrade <= 100)
                {
                    return ('A');
                    
                }
                else if (numGrade >= 80 && numGrade <= 87)
                {
                    return ('B');

                }
                else if (numGrade >= 67 && numGrade <= 79)
                {
                    return ('C');

                }

                else if (numGrade >= 60 && numGrade <= 66)
                {
                    return ('D');

                }
                else if (numGrade >= 0 && numGrade <= 60)
                {
                    return ('F');

                }
                else
                {
                    Console.WriteLine("Invalid Letter Grade");

                }           
       


            }
        }
    }
}
