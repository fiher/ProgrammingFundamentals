using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string given = Console.ReadLine();
           

            switch (given)
            {
                default:
                    given = "other";
                    break;
                case "a":
                    given = "vowel";
                    break;
                case "e":
                    given = "vowel";
                    break;
                case "i":
                    given = "vowel";
                    break;
                case "u":
                    given = "vowel";
                    break;
                case "o":
                    given = "vowel";
                    break;
                case "1":
                    given = "digit";
                    break;
                case "2":
                    given = "digit";
                    break;
                case "3":
                    given = "digit";
                    break;
                case "4":
                    given = "digit";
                    break;
                case "5":
                    given = "digit";
                    break;
                case "6":
                    given = "digit";
                    break;
                case "7":
                    given = "digit";
                    break;
                case "8":
                    given = "digit";
                    break;
                case "9":
                    given = "digit";
                    break;
                case "0":
                    given = "digit";
                    break;

            }
            Console.WriteLine(given);
        }
    }
}
