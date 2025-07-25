using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int maxLength = 0;
            int currentLength = 0;

            for (int i = 0; i <= sentence.Length; i++)
            {
                if (i == sentence.Length || sentence[i] == ' ')
                {  
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    currentLength = 0;
                }
                else
                {
                    currentLength++;
                }
            }
            Console.WriteLine("Length of the longest word: " + maxLength);
        }
    }
}
        

    

