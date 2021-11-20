using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class Circle:Point,IMove,IChangeParametrs
    {
        public Circle(string Color, State State) : base(Color, State)
        {
            this.Color = Color;
            this.State = State;
        }
       override public void CalculateSquare()
        {
            Console.WriteLine("Введите радиус окружности");
            int radius = Convert.ToInt32(Console.ReadLine());
            double sqr = radius * radius * Math.PI;
            Console.WriteLine($"площадь данной окружиности:{sqr}");
        }
    }
}
