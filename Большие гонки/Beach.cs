using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class Beach:IPlay
    {
         void IPlay.Play(Team team)
        {
            Console.WriteLine("Игра пляж. Игроки должны доплыть до своих партнеров на матрассах и вернуться вдвоем");
            Console.WriteLine("Этот игрок доплыл?(Y/N)");
            string answer = Console.ReadLine();
            if (answer.Equals("Yes"))
            {
                team.AddPoint();
                Console.WriteLine($"Эта команда победила и набирает {team.GetPointsNumber} очков");
            }
            else
            {
                Console.WriteLine("Эта команда проиграла и не набирает ни одного очка");
            }
        }

    }
}

