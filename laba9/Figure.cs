using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    public enum State { visible, invisible };
    abstract class Figure:IChangeParametrs, IMove
    {
        public string Color;
        public State State;
        public Figure(string Color, State State)
        {
            this.Color = Color;
            this.State = State;
        }
        public void AskState()
        {
            Console.WriteLine("В каком состоянии находится фигура?");
        }

        void IChangeParametrs.ChangeColor()
        {
            Console.WriteLine("Введите цвет, в который хотите покрасить фигуру");
            string newcolor = Console.ReadLine();
            Color = newcolor;
        }
        void IMove.MoveHorizontally()
        {
            Console.WriteLine("Введите число, на которое вы хотете сдвинуть фигуру по горизонтали");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы сместили фигуру по горизонтали на {x}");
        }
        void IMove.MoveVertically()
        {
            Console.WriteLine("Введите число, на которое вы хотете сдвинуть фигуру по вертикали");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы сместили фигуру по вертикали на {y}");
        }
        public void Print()
        {
            Console.WriteLine($"цвет фигуры:{Color}, состояние фигуры:{State}");
        }
    }
}
