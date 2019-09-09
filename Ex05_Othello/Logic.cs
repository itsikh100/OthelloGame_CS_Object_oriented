using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Othelo
{
    public class Logic
    {
        private int m_row, m_col;

        public Logic(int i_row, int i_col)
        {
            m_row = i_col;
            m_col = i_col;
        }

        public bool CheckUp(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkRow = i_Row - 1;

            if (checkRow >= 0 && checkRow < m_row)
            {
                if (i_Cells[checkRow, i_Col].Value.Equals(i_OpponentPlayer))
                {
                    checkRow--;
                    while (checkRow >= 0)
                    {
                        if (i_Cells[checkRow, i_Col].Value.Equals(eCellValue.Empty))
                        {
                            i_Cells[checkRow, i_Col].Value = eCellValue.Valid;
                            return true;
                        }

                        if (i_Cells[checkRow, i_Col].Value.Equals(i_Color) || i_Cells[checkRow, i_Col].Value.Equals(eCellValue.Valid))
                        {
                            return false;
                        }

                        checkRow--;
                    }
                }
            }

            return false;
        }

        public bool CheckUpLeft(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkRow = i_Row - 1;
            int checkCol = i_Col - 1;

            if (checkRow >= 0 && checkRow < m_row && checkCol >= 0 && checkCol < m_col)
            {
                if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    checkRow--;
                    checkCol--;
                    while (checkRow >= 0 && checkCol >= 0)
                    {
                        if (i_Cells[checkRow, checkCol].Value == eCellValue.Empty)
                        {
                            i_Cells[checkRow, checkCol].Value = eCellValue.Valid;
                            return true;
                        }

                        if (i_Cells[checkRow, checkCol].Value.Equals(i_Color) || i_Cells[checkRow, checkCol].Value.Equals(eCellValue.Valid))
                        {
                            return false;
                        }

                        checkRow--;
                        checkCol--;
                    }
                }
            }
            
            return false;
        }
        
        public bool CheckLeft(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkCol = i_Col - 1;

            if (checkCol >= 0 && checkCol < m_col)
            {
                if (i_Cells[i_Row, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    checkCol--;
                    while (checkCol >= 0)
                    {
                        if (i_Cells[i_Row, checkCol].Value == eCellValue.Empty)
                        {
                            i_Cells[i_Row, checkCol].Value = eCellValue.Valid;
                            return true; 
                        }

                        if (i_Cells[i_Row, checkCol].Value.Equals(i_Color) || i_Cells[i_Row, checkCol].Value.Equals(eCellValue.Valid))
                        {
                            return false; 
                        }

                        checkCol--;
                    }
                }
            }
            
            return false;
        }

        public bool CheckDownLeft(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkRow = i_Row + 1;
            int checkCol = i_Col - 1;

            if (checkRow >= 0 && checkRow < m_row && checkCol >= 0 && checkCol < m_col)
            {
                if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    checkRow++;
                    checkCol--;
                    while (checkRow < m_row && checkCol >= 0)
                    {
                        if (i_Cells[checkRow, checkCol].Value == eCellValue.Empty)
                        {
                            i_Cells[checkRow, checkCol].Value = eCellValue.Valid;
                            return true;
                        }

                        if (i_Cells[checkRow, checkCol].Value.Equals(i_Color) || i_Cells[checkRow, checkCol].Value.Equals(eCellValue.Valid))
                        {
                            return false;
                        }

                        checkRow++;
                        checkCol--;
                    }
                }
            }
            
            return false;
        }
                    
        public bool CheckDown(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkRow = i_Row + 1;

            if (checkRow >= 0 && checkRow < m_row)
            {
                if (i_Cells[checkRow, i_Col].Value.Equals(i_OpponentPlayer))
                {
                    checkRow++;
                    while (checkRow < m_row)
                    {
                        if (i_Cells[checkRow, i_Col].Value == eCellValue.Empty)
                        {
                            i_Cells[checkRow, i_Col].Value = eCellValue.Valid;
                            return true;
                        }

                        if (i_Cells[checkRow, i_Col].Value.Equals(i_Color) || i_Cells[checkRow, i_Col].Value.Equals(eCellValue.Valid))
                        {
                            return false;
                        }

                        checkRow++;
                    }
                }
            }
            
            return false;
        }

        public bool CheckDownRight(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkRow = i_Row + 1;
            int checkCol = i_Col + 1;

            if (checkRow >= 0 && checkRow < m_row && checkCol >= 0 && checkCol < m_col)
            {
                if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    checkRow++;
                    checkCol++;
                    while (checkRow < m_row && checkCol < m_col)
                    {
                        if (i_Cells[checkRow, checkCol].Value == eCellValue.Empty)
                        {
                            i_Cells[checkRow, checkCol].Value = eCellValue.Valid;
                            return true;
                        }

                        if (i_Cells[checkRow, checkCol].Value.Equals(i_Color) || i_Cells[checkRow, checkCol].Value.Equals(eCellValue.Valid))
                        {
                            return false;
                        }

                        checkRow++;
                        checkCol++;
                    }
                }
            }
            
            return false;
        }

        public bool CheckRight(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkCol = i_Col + 1;

            if (checkCol >= 0 && checkCol < m_col)
            {
                if (i_Cells[i_Row, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    checkCol++;
                    while (checkCol < m_col)
                    {
                        if (i_Cells[i_Row, checkCol].Value == eCellValue.Empty)
                        {
                            i_Cells[i_Row, checkCol].Value = eCellValue.Valid;
                            return true;
                        }

                        if (i_Cells[i_Row, checkCol].Value.Equals(i_Color) || i_Cells[i_Row, checkCol].Value.Equals(eCellValue.Valid))
                        {
                            return false;
                        }

                        checkCol++;
                    }
                }
            }
            
            return false;
        }

        public bool CheckUpRight(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int checkRow = i_Row - 1;
            int checkCol = i_Col + 1;

            if (checkRow >= 0 && checkRow < m_row && checkCol >= 0 && checkCol < m_col)
            {
                if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    checkRow--;
                    checkCol++;
                    while (checkRow >= 0 && checkCol < m_col)
                    {
                        if (i_Cells[checkRow, checkCol].Value == eCellValue.Empty)
                        {
                            i_Cells[checkRow, checkCol].Value = eCellValue.Valid;
                            return true;
                        }

                        if (i_Cells[checkRow, checkCol].Value.Equals(i_Color) || i_Cells[checkRow, checkCol].Value.Equals(eCellValue.Valid))
                        {
                            return false;
                        }

                        checkRow--;
                        checkCol++;
                    }
                }
            }
            
            return false;
        }

        public void FlipUp(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {            
            int flipSquares = 0;
            int checkRow = i_Row - 1; 
            bool matchFound = false;
          
            while (checkRow >= 0 && !matchFound)
            {                                
                if (i_Cells[checkRow, i_Col].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;              
                }
                else
                {
                    if(i_Cells[checkRow, i_Col].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }                

                checkRow--;
            }

            if (matchFound && flipSquares > 0)
            {       
                i_Cells[i_Row, i_Col].Value = i_Color;
                while (flipSquares >= 0)
                {
                    i_Row--;
                    flipSquares--;                   
                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }         
        }

        public void FlipUpLeft(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int flipSquares = 0;
            int checkRow = i_Row - 1;
            int checkCol = i_Col - 1;
            bool matchFound = false;

            while (checkRow >= 0 && checkCol >= 0 && !matchFound)
            {            
                if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;
                }
                else
                {
                    if (i_Cells[checkRow, checkCol].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }

                checkRow--;
                checkCol--;
            }

            if (matchFound && flipSquares > 0)
            {
                i_Cells[i_Row, i_Col].Value = i_Color;

                while (flipSquares >= 0)
                {
                    i_Row--;
                    i_Col--;
                    flipSquares--;
                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }
        }

        public void FlipLeft(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int flipSquares = 0;
            int checkCol = i_Col - 1;
            bool matchFound = false;

            while (checkCol >= 0 && !matchFound)
            {
                 if (i_Cells[i_Row, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;
                }
                else
                {
                    if (i_Cells[i_Row, checkCol].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }

                checkCol--;
            }

            if (matchFound && flipSquares > 0)
            {
                i_Cells[i_Row, i_Col].Value = i_Color;

                while (flipSquares >= 0)
                {
                    i_Col--;
                    flipSquares--;
                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }
        }

        public void FlipDownLeft(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int flipSquares = 0;
            int checkRow = i_Row + 1; 
            int checkCol = i_Col - 1; 
            bool matchFound = false;

            while (checkRow < m_row && checkCol >= 0 && !matchFound)
            {
                if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;
                }
                else
                {
                    if (i_Cells[checkRow, checkCol].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }

                checkRow++;
                checkCol--;
            }

            if (matchFound && flipSquares > 0)
            {
                i_Cells[i_Row, i_Col].Value = i_Color;

                while (flipSquares >= 0)
                {
                    i_Row++;
                    i_Col--;
                    flipSquares--;
                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }
        }

        public void FlipDown(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int flipSquares = 0;
            int checkRow = i_Row + 1;
            bool matchFound = false;

            while (checkRow < m_row && !matchFound)
            {              
                if (i_Cells[checkRow, i_Col].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;
                }
                else
                {
                    if (i_Cells[checkRow, i_Col].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }

                checkRow++;
            }

            if (matchFound && flipSquares > 0)
            {
                i_Cells[i_Row, i_Col].Value = i_Color;

                while (flipSquares >= 0)
                {
                    i_Row++;
                    flipSquares--;
                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }
        }

        public void FlipDownRight(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int flipSquares = 0;
            int checkRow = i_Row + 1; 
            int checkCol = i_Col + 1;
            bool matchFound = false;
            while (checkRow < m_row && checkCol < m_col && !matchFound)
            {
                if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;
                }
                else
                {
                    if (i_Cells[checkRow, checkCol].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }

                checkRow++;
                checkCol++;
            }

            if (matchFound && flipSquares > 0)
            {
                i_Cells[i_Row, i_Col].Value = i_Color;

                while (flipSquares >= 0)
                {
                    i_Row++;
                    i_Col++;
                    flipSquares--;

                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }
        }

        public void FlipRight(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int flipSquares = 0;
            int checkCol = i_Col + 1;
            bool matchFound = false;

            while (checkCol < m_col && !matchFound)
            {
                if (i_Cells[i_Row, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;
                }
                else
                {
                    if (i_Cells[i_Row, checkCol].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }

                checkCol++;
            }

            if (matchFound && flipSquares > 0)
            {
                i_Cells[i_Row, i_Col].Value = i_Color;

                while (flipSquares >= 0)
                {
                    i_Col++;
                    flipSquares--;
                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }
        }

        public void FlipUpRight(Cell[,] i_Cells, int i_Row, int i_Col, eCellValue i_Color, eCellValue i_OpponentPlayer)
        {
            int flipSquares = 0;
            int checkRow = i_Row - 1;
            int checkCol = i_Col + 1;
            bool matchFound = false;

            while (checkRow >= 0 && checkCol < m_col && !matchFound)
            {
               if (i_Cells[checkRow, checkCol].Value.Equals(i_OpponentPlayer))
                {
                    flipSquares++;
                }
                else
                {
                    if (i_Cells[checkRow, checkCol].Value.Equals(i_Color))
                    {
                        matchFound = true;
                    }
                }

                checkRow--;
                checkCol++;
            }

            if (matchFound && flipSquares > 0)
            {
                i_Cells[i_Row, i_Col].Value = i_Color;

                while (flipSquares >= 0)
                {
                    i_Row--;
                    i_Col++;
                    flipSquares--;
                    i_Cells[i_Row, i_Col].Value = i_Color;
                }
            }
        }

        public void ClearValidCells(Cell[,] i_Cells)
        {
            for (int row = 0; row < m_row; row++)
            {
                for (int col = 0; col < m_col; col++)
                {
                    if(i_Cells[row, col].Value.Equals(eCellValue.Valid))
                    {
                        i_Cells[row, col].Value = eCellValue.Empty;
                    }
                }
            }
        }

        public bool GameOver(eCellValue i_CurrentPlayercolor, int i_CurrentPlayerScore, int i_OpponentPlayerScore, bool i_CurrentPlayerHasMove)
        {
            if (i_CurrentPlayerScore + i_OpponentPlayerScore == m_row * m_col)
            {
                return true;
            }

            if (i_OpponentPlayerScore == 0 || i_CurrentPlayerScore == 0)
            {
                return true;
            }

            if (i_CurrentPlayerHasMove)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RestartBoard(Cell[,] i_Cells)
        {
            for (int row = 0; row < m_row; row++)
            {
                for (int col = 0; col < m_col; col++)
                {
                    i_Cells[row, col].Value = eCellValue.Empty;
                }
            }
        }
    }
}
