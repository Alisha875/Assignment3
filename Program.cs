using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: TryParse for integer conversion
            string intString = "123";
            int parsedInt;

            if (int.TryParse(intString, out parsedInt))
            {
                Console.WriteLine($"Successfully parsed '{intString}' to integer: {parsedInt}");
            }
            else
            {
                Console.WriteLine($"Failed to parse '{intString}' to integer");
            }

            // Example 2: Convert for double conversion
            string doubleString = "45.67";
            try
            {
                double convertedDouble = Convert.ToDouble(doubleString);
                Console.WriteLine($"Successfully converted '{doubleString}' to double: {convertedDouble}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error: '{doubleString}' is not a valid double value");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Error: '{doubleString}' is too large to fit in a double");
            }

            // Example 3: Parse for decimal conversion
            string decimalString = "89.12";
            try
            {
                decimal parsedDecimal = decimal.Parse(decimalString);
                Console.WriteLine($"Successfully parsed '{decimalString}' to decimal: {parsedDecimal}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error: '{decimalString}' is not a valid decimal value");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Error: '{decimalString}' is too large to fit in a decimal");
            } 
            Console.ReadKey();
        }
    }
}
