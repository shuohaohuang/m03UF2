/*Author Shuohao Huang
 * Date 6/12/23
 * Resume Implementa un programa que donat un nombre decimal introduït per teclat retorni la part entera i la part decimal d’aquest.
 */


using System.Globalization;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Insert a decimal number";
            const string IntegerMsg = "The integer part is ";
            const string DecimalMsg = "The decimal part is ";

            decimal insert; //Use float instead float for more precision 
            Console.WriteLine(Msg);
            insert = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(IntegerMsg+GetInteger(insert));
            Console.WriteLine(DecimalMsg+GetDecimal(insert));

        }

        static int GetInteger(decimal num)
        {
            return (int)(num - (GetDecimal(num)));
        }
        static decimal GetDecimal(decimal num)
        {
            return num % 1;
        }
    }
}
