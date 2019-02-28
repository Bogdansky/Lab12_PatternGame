using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    abstract class Pizza
    {
        public Uri ConstPizza { get; set; }
        public abstract void Consist();
    }
}
