using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class MouseTrap:IPlay
    {
        void IPlay.Play(Team team)
        {
            Console.WriteLine("Игра мышеловка. Игроки должны перенести паралоновую фигуру в виде куска сыра на другой конец поля, избегая столкновения с быком");
            Console.WriteLine("Введите скорость игрока от 1 до 5");
            int speed = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out speed))
            {
                Console.WriteLine("Ошибка, повторите ввод");
            }
            if (speed >= 3)
            {
                Console.WriteLine("Игрок смог убежать от быка!");
                team.AddPoint();
                Console.WriteLine($"Эта команда победила и набирает {team.GetPointsNumber} очков");
            }
            else
            {
                Console.WriteLine("Ой, игрок напопролся на быка");
                Console.WriteLine("Эта команда проиграла и не набирает ни одного очка");
            }
        }

    }
}
