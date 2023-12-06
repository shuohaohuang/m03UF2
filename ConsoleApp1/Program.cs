/* Author: Shuohao huang
 * Date : 5/12/2023
 * Summary:Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
*/


using Microsoft.VisualBasic;

namespace ConsoleApp2
{
    public class ej15
    {

        static void Main(string[] args)
        {

            const string Msg = "Insert a year date";
            const string LeapYearMsg = "Is a leap year";
            const string NoLeapYearMsg = " Isn't a leap  year";

            Console.WriteLine(Msg);
            Console.Write(LeapYear(GetInt()) ? LeapYearMsg : NoLeapYearMsg);

        }
        public static int GetInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static bool LeapYear(int year)
        {
            return multipleOfFour(year) && (multipleOfHundred(year) && multipleOfFourHundred(year) || !multipleOfHundred(year) && !multipleOfFourHundred(year));
        }
        public static bool multipleOfFour(int input)
        {
            return input % 4 == 0;
        }
        public static bool multipleOfHundred(int input)
        {
            return input % 100 == 0;
        }
        public static bool multipleOfFourHundred(int input)
        {
            return input % 400 == 0;
        }


    }
}
