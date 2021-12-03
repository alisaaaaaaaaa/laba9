using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class Sea:IPlay
    {
        void IPlay.Play(Team team)
        {
            Console.WriteLine("Игра море.Игроки должны преодалевать полосу препятсвий, находящуюся в бассейне.После прохождения полосы нужно передать эстафету следующему игроку");
            Console.WriteLine("Введите номер первого участника эстафеты, если он прошел полосу препятвий, и введите не прошёл, если игрок упал в море");
            string player1 = Console.ReadLine();
            if (player1.Equals("не прошёл"))
            {
                Console.WriteLine("К сожалению, этот участник не прошел полосу препятсвий, поэтому команда выбывает и не набирает ни одного очка");
            }
            else
            {
                Console.WriteLine("Игрок успешно прошел полосу препятвий, введите номер следующего инрока или не прошел");
                string player2 = Console.ReadLine();
                if (player1.Equals("не прошёл"))
                {
                    Console.WriteLine("К сожалению, этот участник не прошел полосу препятсвий, поэтому команда выбывает и не набирает ни одного очка");
                }
                else
                {
                    Console.WriteLine("Игрок успешно прошел полосу препятвий, и команда одерживает победу в этой игре");
                    team.AddPoint();
                    Console.WriteLine($"Эта команда победила и набирает {team.GetPointsNumber} очков");
                }
            }
        }

    }
}

