using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovCSharpBook06ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a group of numbers that you want to check for minimal and maximal number: ");
            string userInp = Console.ReadLine();

            int num = 0;

            bool checkInput = int.TryParse(userInp, out num);

            if (checkInput)
            {
                List<double> digiList = new List<double>();
                for (int i = 0; i < num; i++)
                {
                    Console.Write("Please enter number {0}: ", i + 1);
                    digiList.Add(double.Parse(Console.ReadLine()));
                }

                double min = digiList.Min();
                double max = digiList.Max();
                Console.WriteLine("The smallest number in the sequence is {0}", min);
                Console.WriteLine("The biggest number in the in the input {0}", max);
            }

            else { Console.WriteLine("Please enter an integer"); };

        }
    }
}
