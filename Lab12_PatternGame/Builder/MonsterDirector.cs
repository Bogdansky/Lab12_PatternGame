using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    class MonsterDirector
    {
        private readonly IMonsterBuilder builder;

        public MonsterDirector(MonsterBuilder _builder)
        {
            builder = _builder;
        }

        public string CreateMonster(string head, string body, string hands, string legs)
        {
            builder.BuildHead(head);
            builder.BuildBody(body);
            builder.BuildHands(hands);
            builder.BuildLegs(legs);
            return builder.GetResult();
        }
    }
}
