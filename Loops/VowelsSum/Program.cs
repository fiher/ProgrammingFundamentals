using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int s = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    s += 1;
                }
                else if (text[i] =='e')
                {
                    s += 2;
                }
                else if (text[i] == 'i')
                {
                    s += 3;
                }
                else if (text[i] == 'o')
                {
                    s += 4;
                }
                else if (text[i] == 'u')
                {
                    s += 5;
                }
                Console.WriteLine(s);
            }

        }
    }
}
