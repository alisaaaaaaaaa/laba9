using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class Postmen:IPlay
    {
        void IPlay.Play(Team team)
        {
            Console.WriteLine("Игра Почтальоны");
            Console.WriteLine("что то делают, играют в почтальонов;)");
        }
    }
}
