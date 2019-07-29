using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guess = 0;
            string welcome = "Gondolj egy számra 1 és 100 között";
            int num = rnd.Next(1, 100);
            Console.WriteLine(welcome);

            int i = 0;

            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess > num)
                    {
                        Console.WriteLine("Túl sok, agyaljál még!");
                    }
                    else
                    {
                        Console.WriteLine("Túl kevés, vagy mégsem?" );
                    }
                }
                catch
                {
                    Console.WriteLine("Mindenképp számnak kell lennie");
                    i--;
                    
                }

                i++;
            }
            Console.WriteLine("Gratulálok #@&! meg, " + i + "próbálkozásba telt");
            Console.ReadLine();
        }
    }
}