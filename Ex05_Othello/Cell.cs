using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Othelo
{
    public class Cell
    {
        public Cell()
        {
            Value = eCellValue.Empty;
        }
     
        public eCellValue Value { get; set; }
    }
}
