using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class Slide:IPlay
    {
        void IPlay.Play(Team team)
        {
            Console.WriteLine("Игра горка. Игроки должны забраться на вершину горы с помощью сил рук, причем первый игрок стартует с позиции в зависимости от количества набранных очков, а следующий с самого низа");
            Console.WriteLine($"Первый игрок стартует с {team.GetPointsNumber} позиции");
            Console.WriteLine("Введите время, за которое воторой игрок поднялся наверх(в секундах)");
            int time = Convert.ToInt32(Console.ReadLine());
            while(!int.TryParse(Console.ReadLine(), out time))
            {
                Console.WriteLine("Ошибка! Повторите ввод");
            }
            if (time <= 15)
            {
                Console.WriteLine("Команда прошла испытание быстро и одерживает победу в этой игре");
                team.AddPoint();
                Console.WriteLine($"По итогам Больших Гонок команда набирает {team.GetPointsNumber} очков");
            }
            else
            {
                Console.WriteLine("Команда слишком долго проходила это испытание и теряет победу");
                Console.WriteLine($"По итогам Больших Гонок команда набирает {team.GetPointsNumber} очков");
            }
        }

    }
}

