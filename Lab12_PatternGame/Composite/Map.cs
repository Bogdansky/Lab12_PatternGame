using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    class Map : IMain
    {
        private readonly List<IMain> _map = new List<IMain>();

        public Map()
        {
            Title = "Карта";
        }

        public string Title { get; set; }
        public void Draw() { }
        public void AddComponent(IMain main)
        {
            _map.Add(main);
        }

        public IMain Find(string title)
        {
            var mapping = from map in _map where map.Title == title select map;
            return mapping != null ? mapping.First() : null;
        }
    }
}
