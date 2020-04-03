using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if ((number < start) || (number > end)) throw new ArgumentOutOfRangeException("Number is out of range!");

            return number;
        }
        static void Main(string[] args)
        {
            int start = 1, end = 50;

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Enter a number between {0} and {1}:",start,end);
                    start = ReadNumber(start, end);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ParamName);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
