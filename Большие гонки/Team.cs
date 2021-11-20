using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class Team : Player, IPlay
    {
        Player Player1;
        Player Player2;
        Player Player3;
        Player Player4;
        Player Player5;
        Player Player6;
        Player Player7;
        Player Player8;
        Player Player9;
        Player Player10;
        Player Player11;
        Player Player12;
        Player Player13;
        Player Player14;
        Player Player15;
        int PointsNumber;
        public Team(string Name, int Number, string Country, int Speed) : base(Name, Number, Country, Speed)
        {
            this.Name = Name;
            this.Number = Number;
            this.Country = Country;
            this.Speed = Speed;
        }
        public static int AddPoint(int PointsNumber)
        {
            PointsNumber++;
            return PointsNumber;
        }
        void IPlay.Beach()
        {
            Console.WriteLine("Игра пляж. Игроки должны доплыть до своих партнеров на матрассах и вернуться вдвоем");
            Console.WriteLine("Этот игрок доплыл?(Y/N)");
            string answer = Console.ReadLine();
            if (answer.Equals("Yes"))
            {
                Team.AddPoint(PointsNumber);
                Console.WriteLine($"Эта команда победила и набирает {Team.AddPoint(PointsNumber)} очков");
            }
            else
            {
                Console.WriteLine("Эта команда проиграла и не набирает ни одного очка");
            }
        }
        void IPlay.Mousetrap()
        {
            Console.WriteLine("Игра мышеловка. Игроки должны перенести паралоновую фигуру в виде куска сыра на другой конец поля, избегая столкновения с быком");
            if (Player3.Speed >= 3)
            {
                Console.WriteLine("Игрок смог убежать от быка!");
                Team.AddPoint(PointsNumber);
                Console.WriteLine($"Эта команда победила и набирает {Team.AddPoint(PointsNumber)} очков");
            }
            else
            {
                Console.WriteLine("Ой, игрок напопролся на быка");
                Console.WriteLine("Эта команда проиграла и не набирает ни одного очка");
            }
        }
        void IPlay.Sea()
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
                    Team.AddPoint(PointsNumber);
                    Console.WriteLine($"Эта команда победила и набирает {Team.AddPoint(PointsNumber)} очков");
                }
            }
        }
        void IPlay.Slidse()
        {
            Console.WriteLine("Игра горка. Игроки должны забраться на вершину горы с помощью сил рук, причем первый игрок стартует с позиции в зависимости от количества набранных очков, а следующий с самого низа");
            Console.WriteLine($"Первый игрок стартует с {Team.AddPoint(PointsNumber)} позиции");
            Console.WriteLine("Введите время, за которое воторой игрок поднялся наверх(в секундах)");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time <= 15 )
            {
                Console.WriteLine("Команда прошла испытание быстро и одерживает победу в этой игре");
                Team.AddPoint(PointsNumber);
                Console.WriteLine($"По итогам Больших Гонок команда набирает {Team.AddPoint(PointsNumber)} очков");
            }
            else
            {
                Console.WriteLine("Команда слишком долго проходила это испытание и теряет победу");
                Console.WriteLine($"По итогам Больших Гонок команда набирает {Team.AddPoint(PointsNumber)} очков");
            }
        }
        }
    }


