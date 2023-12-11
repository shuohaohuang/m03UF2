/*Author Shuohao huang
 * Date 6/!"/"·
 * Resum: Implementa un mètode que rebiun nombre enter (minuts) i retorni la seva conversió a segons.
 */ 

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Input the number of minutes you want to convert into seconds";
            const string SecondsMsg = "{0} minutes are {1} seconds";

            int input;

            Console.WriteLine(Msg);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SecondsMsg,input,MinIntoSecond(input));

        }

        public static int MinIntoSecond(int min)
        {
            return min * 60;
        }
    }
}
