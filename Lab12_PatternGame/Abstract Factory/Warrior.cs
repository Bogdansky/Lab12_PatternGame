using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    public class Warrior : IGameObject
    {
        public string Type => "warrior";
        public int X { get; set; }
        public int Y { get; set; }
        public string Title { get; set; }
        public static int Counter = 0;

        public Warrior()
        {
            Title = "Воин"+Counter++;
        }

        public void Draw() { }
    }
}
