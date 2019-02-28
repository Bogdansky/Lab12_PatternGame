using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    class Geometry : IGameObject
    {
        public string Type => "Geometric figure";
        public int X { get; set; }
        public int Y { get; set; }
        public string Title { get; set; }
        public static int Counter = 0;

        public Geometry()
        {
            Title = "Фигурка" + Counter++;
        }

        public void Draw() { }
    }
}
