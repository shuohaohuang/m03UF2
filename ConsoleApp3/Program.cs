/*Author Shuohao Huang
 * Date 6/12/23
 * Resum:Implementa un programa que demani a l’usuari quants valors vol introduir, de manera que el programa generi una llista a partir de valors introduïts per teclat i retorni el producte de tots els elements d’aquesta. Els valors que l’usuari pot introduir són entre (15, 100) i l’usuari disposa de 5 intents en total.
 * 
 */



using System.ComponentModel;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "How may numbers do you want in ?";
            const string ResultMsg = "The product of all numbers in the list is ";
            const string DoMsg = "Insert numbers between 16 and 99 until fill the list";
            int tries = 5,min=15,max=100;
            Console.WriteLine(Msg);

            int[] userArray = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine(DoMsg);
            IntArray(ref userArray, min, max, ref tries);
            
            if(Try(tries))
                Console.WriteLine(ResultMsg+IntArray(userArray));
        }

        public static void IntArray(ref int[] array, int min, int max,ref int tries )
        {
            int[] wrong = new int[array.Length];
            for (int i = 0; i < array.Length&&tries!=0; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
               if (InInterval(input,min,max))
               {
                    array[i] = input;
                    Console.WriteLine("In interval");
                }
                else
                {
                    Console.WriteLine("Not in interval");
                    tries--;
                    i--;
                }  
            }
            if (!Try(tries)) 
            Console.WriteLine("Too many mistakes, the program is going to shutdown");
        }
        public static double IntArray(int[] array)
        {
            double result=1;
            foreach (int i in array)
                result *= i;
            return result;
        }
        public static bool InInterval(int insert,int min, int max)
        {
            return insert >= min && insert <= max;
        }
        public static bool Try(int tries)
        {
            return tries>0;
        }
    }
}
