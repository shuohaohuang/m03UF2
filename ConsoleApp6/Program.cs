/* Author Shuohao Huang
 * Date 6/12/23
 * Resum: Implementa un programa que retorni el màxim i mínim de dos valors enters introduïts per teclat.
 */

using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Insert two numbers";
            const string MinMsg = "{0} is the small one";
            const string MaxMsg = "{0} is the big one";
            const int Two = 2;
            bool max = true;
            Console.WriteLine(Msg);
            int[] inputs = new int[Two];
            for(int i=0;i< inputs.Length;i++)
            {
                inputs[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(MinMsg, IntArray(inputs,!max));
            Console.WriteLine(MaxMsg, IntArray(inputs, max));
        }

        public static int IntArray(int[] array, bool max)
        {
            int bigger;
            for (int i = 0; i < array.Length; i++)
            {
                int aux;
                for (int j = 1;j < array.Length-1; j++) 
                {
                    if (array[i] < array[j])
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return max ? array[0] : array[array.Length-1];
        }

    }
}
