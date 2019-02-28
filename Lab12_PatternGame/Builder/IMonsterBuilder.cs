using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    interface IMonsterBuilder
    {
        void BuildHead(string beast);
        void BuildBody(string beast);
        void BuildHands(string beast);
        void BuildLegs(string beast);
        string GetResult();
    }
}
