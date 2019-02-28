using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    class MonsterBuilder : IMonsterBuilder
    {
        private string result = String.Empty;

        public void BuildHead(string beast)
        {
            result += " с головой [" + beast + "],";
        }

        public void BuildBody(string beast)
        {
            result += " с телом [" + beast + "],";
        }

        public void BuildHands(string beast)
        {
            result += " с руками [" + beast + "] и";
        }

        public void BuildLegs(string beast)
        {
            result += " с ногами [" + beast + "] ";
        }

        public string GetResult()
        {
            return "Монстр"+result;
        }
    }
}
