using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class Rectangle:Point
    {
        public Rectangle(string Color, State State) : base(Color, State)
        {
            this.Color = Color;
            this.State = State;
        }
        public override void CalculateSquare()
        {
            Console.WriteLine("Введите длину и ширину прямоугольника");
            int width = Convert.ToInt32(Console.ReadLine());
            int lenght = Convert.ToInt32(Console.ReadLine());
            int sqr = width * lenght;
            Console.WriteLine($"площадь данной окружиности:{sqr}");
        }
    }
}
