﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    public interface IGameObject : IMain
    {
        string Type { get; }
        int X { get; set; }
        int Y { get; set; }
    }
}
