using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex02_Othelo
{
    public partial class OthelloGameForm : Form
    {
        private readonly int m_Rows, m_Cols;
        private Button[,] m_ButtonMatrix;
        public Game m_Game;
        private bool m_GameOver = false;
        private int m_BlackWins, m_WhiteWins = 0;

        public OthelloGameForm(int i_SizeOfBoard, Game i_Game)
        {
            m_Game = i_Game;
            m_Rows = i_SizeOfBoard;
            m_Cols = i_SizeOfBoard;
            InitializeComponent(m_Rows, m_Cols);
            m_Game.board = new Board(m_Rows, m_Cols);
            m_ButtonMatrix = new Button[m_Rows, m_Cols];
            InitButonMatrix();
        }

        private void play()
        {
            m_GameOver = false;
            m_Game.RestartGame();
            updateBoard();
            this.Refresh();
        }

        private void InitButonMatrix()
        {
            for (int row = 0; row < m_Rows; row++)
            {
                for (int col = 0; col < m_Cols; col++)
                {
                    m_ButtonMatrix[row, col] = CreateButton(row, col);
                    flowLayoutPanel1.Controls.Add(m_ButtonMatrix[row, col]);
                }
            }
        }

        private void updateButton(Button i_Btn, int i_Row, int i_Col)
        {
            eCellValue cellContent;
            cellContent = m_Game.board.GetCurrentCell(i_Row, i_Col).Value;

            if (cellContent.Equals(eCellValue.Empty))
            {
                i_Btn.BackColor = Color.LightGray;
                i_Btn.Text = string.Empty;
                i_Btn.Enabled = false;
            }

            if (cellContent.Equals(eCellValue.Black))
            {
                i_Btn.BackColor = Color.Black;
                i_Btn.Text = "O";
                i_Btn.ForeColor = Color.White;
                i_Btn.Enabled = true;
            }

            if (cellContent.Equals(eCellValue.White))
            {
                i_Btn.BackColor = Color.White;
                i_Btn.Text = "O";
                i_Btn.ForeColor = Color.Black;
                i_Btn.Enabled = true;
            }

            if (cellContent.Equals(eCellValue.Valid))
            {
                i_Btn.BackColor = Color.Green;
                i_Btn.Text = string.Empty;
                i_Btn.Enabled = true;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Button CreateButton(int i_Row, int i_Col)
        {
            Button btn = new Button();
            btn.Name = string.Format("{0},{1}", i_Row.ToString(), i_Col.ToString());
            btn.Width = 50;
            btn.Height = 50;
            btn.Location = new System.Drawing.Point((i_Row * 50) + 25, (i_Col * 50) + 25);
            btn.Margin = new System.Windows.Forms.Padding(0);
            updateButton(btn, i_Row, i_Col);
            btn.Click += btn_Click;

            return btn;
        }

        private void printGameOver()
        {
            string str;
            if (m_Game.GetPlayerScore(1).Equals(m_Game.GetPlayerScore(2)))
            {
                str = string.Format("Its a Draw!");
            }
            else
            {
                if (m_Game.GetPlayerScore(1) > m_Game.GetPlayerScore(2))
                {
                    m_BlackWins++;
                }
                else
                {
                    m_WhiteWins++;
                }

                str = string.Format("{0}'s Won!!",
                       m_Game.GetPlayerScore(1) > m_Game.GetPlayerScore(2) ? "Black" : "White");
            }

            string temp = str;
            str = string.Format("{0} (B score: {1} / W score {2})(B wins: {3} / W wins: {4}){5} Would you lika another round ? ",
                    temp,
                    m_Game.GetPlayerScore(1),
                    m_Game.GetPlayerScore(2),
                    m_BlackWins,
                    m_WhiteWins,
                    Environment.NewLine);

            DialogResult dr = MessageBox.Show(str, "Othello", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    play();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int row, col = 0;

            string[] RowAndCol = btn.Name.Split(char.Parse(","));
            int.TryParse(RowAndCol[0], out row);
            int.TryParse(RowAndCol[1], out col);
            if (m_GameOver)
            {
                printGameOver();
            }

            if (m_Game.board.GetCurrentCell(row, col).Value != eCellValue.Black && m_Game.board.GetCurrentCell(row, col).Value != eCellValue.White)
            {
                m_Game.CurrentPlayerMove(row, col);
                m_GameOver = m_Game.IsGameOver();

                if (m_Game.ComputerTurn() && !m_GameOver)
                {
                    Ex02_Othelo.Point ComputerRowAndCol = m_Game.ComputerRandomMove();
                    m_Game.CurrentPlayerMove(ComputerRowAndCol.Row, ComputerRowAndCol.Col);
                    m_GameOver = m_Game.IsGameOver();
                }

                updateBoard();
                if (m_GameOver)
                {
                    printGameOver();
                }

                this.Text = string.Format("{0}'s turn", checkCurrentPlayer());
            }
        }

        private string checkCurrentPlayer()
        {
            return m_Game.GetCurrentPlayer().Name == "Player One" ? "Black" : "White";
        }

        private void updateBoard()
        {
            for (int row = 0; row < m_Rows; row++)
            {
                for (int col = 0; col < m_Cols; col++)
                {
                    updateButton(m_ButtonMatrix[row, col], row, col);
                }
            }
        }
    }
}