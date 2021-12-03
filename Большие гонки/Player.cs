using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    public class Player
    {
        public string Name;
        public int Number;
        public string Country;
        public Player(string Name, int Number, string Country)
        {
            this.Name = Name;
            this.Number = Number;
            this.Country = Country;
        }
    }
}
