using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PatternGame
{
    interface IMove
    {
        string Move(int top, int left); // если значение отрицательное, то направление идёт в обратную сторону (top=-1 - назад на 1)
    }
}
