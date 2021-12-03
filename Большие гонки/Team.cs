using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    public class Team : Player
    {
        public Player Player1;
        public Player Player2;
        public Player Player3;
        public Player Player4;
        public Player Player5;
        public Player Player6;
        public Player Player7;
        public Player Player8;
        public Player Player9;
        public Player Player10;
        public Player Player11;
        public Player Player12;
        public Player Player13;
        public Player Player14;
        public Player Player15;
        public int PointsNumber;
        public Team(string Name, int Number, string Country) : base(Name, Number, Country)
        {
            this.Name = Name;
            this.Number = Number;
            this.Country = Country;
        }
        public void AddPoint()
        {
            PointsNumber++;
        }
        public int GetPointsNumber { get; }

    }
}


