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
            foreach (char c in str)
            {
                if (c.Equals(" ") || c.Equals(",") || c.Equals("."))
                {
                    newstr += c;
                }
                else
                {
                    char letter = char.ToLower(c);
                    char nextBukovka;
                    if (letter == 'z')
                    {
                        nextBukovka = 'a';
                    }
                    else
                    {
                        nextBukovka = (char)(((int)letter) + 1);
                    }
                    newstr += c;
                }
            }
        }
        void ICipher.decode()
        {
            Console.WriteLine("Введите строку, которую требуется расшифровать");
            string str = Console.ReadLine();
            string newstr = "";
            foreach (char c in str)
            {
                if (c.Equals(" ") || c.Equals(",") || c.Equals("."))
                {
                    newstr += c;
                }
                else
                {
                    char letter = char.ToLower(c);
                    char nextBukovka;
                    if (letter == 'a')
                    {
                        nextBukovka = 'z';
                    }
                    else
                    {
                        nextBukovka = (char)(((int)letter) - 1);
                    }
                    newstr += c;
                }
            }
        }
    }
}