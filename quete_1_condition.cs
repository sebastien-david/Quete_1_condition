using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Minimum: ");
            string miniString = Console.ReadLine();
            int mini = Convert.ToInt32(miniString);
            Console.Write("Maximum: ");
            string maxiString = Console.ReadLine();
            int maxi = Convert.ToInt32(maxiString);
            Console.Write("Integer: ");
            string valeurstring = Console.ReadLine();
            int valeur = Convert.ToInt32(valeurstring);

            if (valeur < mini)
            {
                Console.WriteLine("You are entered " + valeur + " which is lower than " + mini + " which is the minimum");
                Console.WriteLine("Resulting integer: " + mini);
            }
            else if (valeur > maxi)
            {
                Console.WriteLine("You are entered " + valeur + " which is greater than " + maxi + " which is the maximum");
                Console.WriteLine("Resulting integer: " + maxi);
            }
            Console.ReadLine();

        }
    }
}
