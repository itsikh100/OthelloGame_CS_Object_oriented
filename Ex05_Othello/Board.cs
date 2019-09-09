using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Othelo
{
    public class Board
    {
        private int m_Rows, m_Cols;
        private bool m_HasMove;
        private Logic m_Logic;
        private Cell[,] m_Cells;

        public int BlackScore { get; set; }

        public int WhiteScore { get; set; }

        public Board(int i_Rows, int i_Cols)
        {           
            m_Rows = i_Rows;
            m_Cols = i_Cols;
            m_Cells = new Cell[m_Rows, m_Cols];
            m_Logic = new Logic(i_Rows, i_Cols);

            for (int row = 0; row < m_Rows; row++)
            {
                for (int col = 0; col < m_Cols; col++)
                {
                    m_Cells[row, col] = new Cell();
                }
            }

            initDiscsOnBoardForStart();
            IsValidCell(eCellValue.Black);
        }

        private void initDiscsOnBoardForStart()
        {
            int topMiddleRow = (m_Rows / 2) - 1;
            int bottomMiddleRow = m_Rows / 2;
            int leftMiddleColumn = (m_Cols / 2) - 1;
            int rightMiddleColumn = m_Cols / 2;

            m_Cells[topMiddleRow, leftMiddleColumn].Value = eCellValue.White;
            m_Cells[topMiddleRow, rightMiddleColumn].Value = eCellValue.Black;
            m_Cells[bottomMiddleRow, leftMiddleColumn].Value = eCellValue.Black;
            m_Cells[bottomMiddleRow, rightMiddleColumn].Value = eCellValue.White;          
        }

        public bool IsValidCell(eCellValue i_CurrentPlayer)
        {
            m_HasMove = false;
            eCellValue OpponentPlayer;
            if (i_CurrentPlayer.Equals(eCellValue.White))
            {
                OpponentPlayer = eCellValue.Black;
            }
            else
            {
                OpponentPlayer = eCellValue.White;
            }

            for (int row = 0; row < m_Rows; row++)
            {
                for (int col = 0; col < m_Cols; col++)
                {
                    if(m_Cells[row, col].Value.Equals(i_CurrentPlayer))
                    {
                        if(m_Logic.CheckUp(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                        {
                            m_HasMove = true;
                        }

                        if(m_Logic.CheckUpLeft(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                            {
                                m_HasMove = true;
                            }

                        if (m_Logic.CheckLeft(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                            {   
                                m_HasMove = true;
                            }

                        if (m_Logic.CheckDownLeft(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                            {
                                m_HasMove = true;
                            }

                        if (m_Logic.CheckDown(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                            {   
                                m_HasMove = true;
                            }

                        if (m_Logic.CheckDownRight(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                            {
                                m_HasMove = true;
                            }

                        if (m_Logic.CheckRight(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                            {
                                m_HasMove = true;
                            }

                        if (m_Logic.CheckUpRight(m_Cells, row, col, i_CurrentPlayer, OpponentPlayer))
                            {
                            m_HasMove = true;
                            }                      
                    }  
                }
            }

            return m_HasMove;
        }  

        public void FlipOpponentsDiscs(int i_Row, int i_Col, eCellValue i_MyPlayer)
        {
            eCellValue opponentPlayer;
            if(i_MyPlayer.Equals(eCellValue.Black))
            {
                opponentPlayer = eCellValue.White;
            }
            else
            {
                opponentPlayer = eCellValue.Black;
            }

            m_Logic.FlipUp(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
            m_Logic.FlipUpLeft(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
            m_Logic.FlipLeft(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
            m_Logic.FlipDownLeft(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
            m_Logic.FlipDown(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
            m_Logic.FlipDownRight(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
            m_Logic.FlipRight(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
            m_Logic.FlipUpRight(m_Cells, i_Row, i_Col, i_MyPlayer, opponentPlayer);
        }

        public void CountScore()
        {
            BlackScore = 0;
            WhiteScore = 0;
            for (int row = 0; row < m_Rows; row++)
            {
                for (int col = 0; col < m_Cols; col++)
                {
                    if (m_Cells[row, col].Value == eCellValue.Black)
                    {
                        BlackScore++;
                    }

                    if (m_Cells[row, col].Value == eCellValue.White)
                    {
                        WhiteScore++;
                    }
                }
            }            
        }
        
        public bool GameOver(eCellValue Color, int i_BlackScore, int i_WhiteScore)
        {
            return m_Logic.GameOver(Color, i_BlackScore, i_WhiteScore, m_HasMove) ? true : false;          
        }

        public Cell GetCurrentCell(int i_Row, int i_Col)
        {        
                return m_Cells[i_Row, i_Col];         
        }

        public int GetSizeOfBoard()
        {
            return m_Rows;
        }

        public void ClearValidCells()
        {
            m_Logic.ClearValidCells(m_Cells);
        }

        public void RestartBoard()
        {
            m_Logic.RestartBoard(m_Cells);
            initDiscsOnBoardForStart();
            IsValidCell(eCellValue.Black);
        }
    }
}