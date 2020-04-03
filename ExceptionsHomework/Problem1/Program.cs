using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static double SqrtNumber(int number)
        {
            double result = 0;
            if (number >= 0)
            {
                result = Math.Sqrt((double)number);
            }
            else
            {
                result = Math.Sqrt((double)number);
                throw new System.ArgumentOutOfRangeException("Negative number!");

            }
            return result;
        }
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Напишете цяло число:");
                int number = int.Parse(Console.ReadLine());
                double result = SqrtNumber(number);
                Console.WriteLine("Sqrt({0}) = {1}", number, result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ParamName);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Invalid number(OverflowException)");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Invalid number(FormatException)");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
