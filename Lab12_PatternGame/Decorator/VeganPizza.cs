using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    class VeganPizza : Pizza
    {
        public const string Name = "Вегетарианская";

        public override void Consist()
        {
            ConstPizza = new Uri("C:\\Users\\User\\source\\repos\\Lab12_PatternGame\\Lab12_PatternGame\\Pizza\\vegan.jpg");
        }
    }
}
