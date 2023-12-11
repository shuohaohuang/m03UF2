/*Author ShuohaoHuang
 * Date 6/12/23
 * Implementa un programa que llegeixi graus en escala Celsius (CC) i els converteixi en graus en escala Fahrenheit (FF). Arrodoneix el resultat a 2 dígits després del punt decimal.
 */

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Inset the current temperature in Celsius";
            const string FahreinheitMsg = "The current temperature in Fahrenheit is ";
            float insert;
            Console.WriteLine(Msg);
            
            Console.WriteLine(FahreinheitMsg+ ToFahrenheit(Convert.ToSingle(Console.ReadLine())));
        }

        public static float ToFahrenheit(float celsius)
        {
            return (float)Math.Round((celsius * 9 / 5) + 32,2);
        }
    }
}
