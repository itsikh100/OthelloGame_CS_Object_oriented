using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Othelo
{
    public class Point
    {
    public Point(int i_Row, int i_Col)
        {
            Row = i_Row;
            Col = i_Col;
        }

        public int Row { get; }

        public int Col { get; }
    }
}
