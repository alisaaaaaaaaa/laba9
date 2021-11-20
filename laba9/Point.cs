using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    abstract class Point : Figure
    {
        public Point(string Color, State State) : base(Color, State)
        {
            this.Color = Color;
            this.State = State;
        }
        abstract public void CalculateSquare();
        
    }
}

