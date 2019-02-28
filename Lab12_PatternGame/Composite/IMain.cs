using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    public interface IMain
    {
        string Title { get; set; }
        void Draw();
    }
}
