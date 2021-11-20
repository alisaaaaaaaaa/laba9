using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    class Player
    {
        public string Name;
        public int Number;
        public string Country;
        public int Speed;
        public Player(string Name, int Number, string Country,int Speed)
        {
            this.Name = Name;
            this.Number = Number;
            this.Country = Country;
            this.Speed = Speed;
        }
        public int GetSpeed { get; }
    }
}
