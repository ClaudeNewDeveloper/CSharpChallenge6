using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerranktest6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please, enter the number words");
            int numberOfLoops = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < numberOfLoops; j++)
            {

                Console.WriteLine("Please, enter the word");
                String wordTypedByUser = Console.ReadLine();

                var word = wordTypedByUser.ToCharArray();

                StringBuilder charFromEvenIndex = new StringBuilder();

                StringBuilder charFromOddIndex = new StringBuilder();

                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        charFromEvenIndex.Append(Convert.ToString(word[i]));
                    }

                    else
                    {
                        charFromOddIndex.Append(Convert.ToString(word[i]));
                    }
                }

                Console.Write(charFromEvenIndex + " ");

                Console.WriteLine(charFromOddIndex);

            }

            Console.ReadKey();


        }
    }
}
