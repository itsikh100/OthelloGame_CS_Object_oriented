using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Othelo
{
    public class Game
    {
        private Player m_Player1, m_Player2, m_CurrentPlayer, m_OpponentPlayer;
        private bool m_GameOver;

        public Game()
        {
            m_GameOver = false;                               
        }

        public void SetPlayer(int i_NumberOfPlayer, string i_Name)
        {
            if (i_NumberOfPlayer == 1)
            {
                m_Player1 = new Player(i_Name, eCellValue.Black, 2);
                m_Player1.ChangetMyTurn();
                m_CurrentPlayer = m_Player1;
                m_OpponentPlayer = m_Player2;
            }
            else
            {
                m_Player2 = new Player(i_Name, eCellValue.White, 2);
            }
        }

        public Player GetCurrentPlayer()
        {
            if (m_Player1.Turn())
            {
                m_CurrentPlayer = m_Player1;
                m_OpponentPlayer = m_Player2;
            }
            else
            {
                m_CurrentPlayer = m_Player2;
                m_OpponentPlayer = m_Player1;
            }

            return m_CurrentPlayer;
        }

        public string GetPlayerName(int i_NumOfPlayer)
        {
            return i_NumOfPlayer.Equals(1) ? m_Player1.Name : m_Player2.Name;
        }

        public int GetPlayerScore(int i_NumOfPlayer)
        {
            return i_NumOfPlayer.Equals(1) ? m_Player1.Score : m_Player2.Score;        
        }

        public void CurrentPlayerMove(int i_Row, int i_Col)
        {
            if (m_Player1.Turn())
            {
                m_CurrentPlayer = m_Player1;
                m_OpponentPlayer = m_Player2;
            }
            else
            {
                m_CurrentPlayer = m_Player2;
                m_OpponentPlayer = m_Player1;
            }

            board.FlipOpponentsDiscs(i_Row, i_Col, m_CurrentPlayer.DiscColor);
            board.ClearValidCells();
                              
            m_GameOver = board.GameOver(m_OpponentPlayer.DiscColor, m_CurrentPlayer.Score, m_OpponentPlayer.Score);
            board.IsValidCell(m_OpponentPlayer.DiscColor);
            board.CountScore();

            m_Player1.Score = board.BlackScore;
            m_Player2.Score = board.WhiteScore;

            m_CurrentPlayer.ChangetMyTurn();
            m_OpponentPlayer.ChangetMyTurn();
            m_CurrentPlayer = GetCurrentPlayer();          
        }
     
        public bool ComputerTurn()
        {
            return m_CurrentPlayer.Name.Equals("computer") ? true : false;        
        }

        public Point ComputerRandomMove()
        {            
            int numOfValidCells = 0;
            Random rnd = new Random();
            List<Point> ValidCellsPoints = new List<Point>();
            ValidCellsPoints.Clear();         
            for (int i = 0; i < board.GetSizeOfBoard(); i++)
            {
                for (int j = 0; j < board.GetSizeOfBoard(); j++)
                {
                    if (board.GetCurrentCell(i, j).Value.Equals(eCellValue.Valid))
                    {
                        ValidCellsPoints.Add(new Point(i, j));
                        numOfValidCells++;
                    }
                }
            }

            int num = rnd.Next(0, numOfValidCells);
            return ValidCellsPoints[num];
        }

        public bool IsCurrentCellValid(int i_Row, int i_Col)
        {
            return board.GetCurrentCell(i_Row, i_Col).Value.Equals(eCellValue.Valid) ? true : false;           
        }

        public bool IsGameOver()
        {
            return board.GameOver(m_CurrentPlayer.DiscColor, m_CurrentPlayer.Score, m_OpponentPlayer.Score) ? true : false; 
        }

        public void RestartGame()
        {
            m_GameOver = false;
            board.RestartBoard();
        }

        public Board board { get; set; }
    }
}