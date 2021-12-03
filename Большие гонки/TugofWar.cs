using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class TugofWar:IPlay
    {
        void IPlay.Play(Team team)
        {
            Console.WriteLine("Игра Перетягивание каната");
            Console.WriteLine("что т делают перетягивают канат;)");
        }
    }
}
