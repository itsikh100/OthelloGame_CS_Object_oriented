using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Othelo
{   
    public class Player
    {
        private bool m_MyTurn;

        public Player(string i_Name, eCellValue i_DiscColor, int i_Score)
      {
          Name = i_Name;
          DiscColor = i_DiscColor;
          Score = i_Score;
          m_MyTurn = false;
      }

        public bool Turn()
        {
            return m_MyTurn ? true : false;          
        }

        public void ChangetMyTurn()
        {
            m_MyTurn = !m_MyTurn;
        }

        public string Name { get; set; }

        public eCellValue DiscColor { get; set; }

        public int Score { get; set; }
    }
}
