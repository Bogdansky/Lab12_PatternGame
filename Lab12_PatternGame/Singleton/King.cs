using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    [Serializable]
    public class King : Prototype<King>
    {
        private static King king;

        private King() { }

        private const string color = "Gold";

        public static King GetInstance()
        {
            return king ?? (king = new King());
        }
        
    }
}
