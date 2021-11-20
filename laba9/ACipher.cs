using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class ACipher : ICipher
    {
        void ICipher.encode()
        {
            Console.WriteLine("Введите строку, которую требуется зашифровать");
            string str = Console.ReadLine();
            string newstr = "";
            foreach (char bukva in str)
            {
                if (bukva.Equals(" ") || bukva.Equals(",") || bukva.Equals("."))
                {
                    newstr += bukva;
                }
                else
                {
                    char letter = char.ToLower(bukva);
                    char nextBukovka;
                    if (letter == 'z')
                    {
                        nextBukovka = 'a';
                    }
                    else
                    {
                        nextBukovka = (char)(((int)letter) + 1);
                    }
                    newstr += bukva;
                }
            }
        }
        void ICipher.decode()
        {
            Console.WriteLine("Введите строку, которую требуется расшифровать");
            string str = Console.ReadLine();
            string newstr = "";
            foreach (char bukva in str)
            {
                if (bukva.Equals(" ") || bukva.Equals(",") || bukva.Equals("."))
                {
                    newstr += bukva;
                }
                else
                {
                    char letter = char.ToLower(bukva);
                    char nextBukovka;
                    if (letter == 'a')
                    {
                        nextBukovka = 'z';
                    }
                    else
                    {
                        nextBukovka = (char)(((int)letter) - 1);
                    }
                    newstr += bukva;
                }
            }
        }
    }
}