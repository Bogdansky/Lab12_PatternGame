using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    class Adapter : IMove
    {
        private Warrior warrior;

        public Adapter(Warrior warrior) => this.warrior = warrior;

        public string Move(int x, int y)
        {
            warrior.X += x;
            warrior.Y += y;
            int newX = x;
            int newY = y;
            string moving = "";
            moving += x < 0 ? $"воин переместился на {x} назад" : $"воин переместился на {x} вперёд";
            moving += y < 0 ? $" воин переместился на {y} вниз" : $" воин переместился на {y} вверх";
            return moving;
        }
    }
}
