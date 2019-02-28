using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    class GeometryFactory : IFactory
    {
        public IGameObject CreateGameObject()
        {
            return new Geometry();
        }
    }
}
