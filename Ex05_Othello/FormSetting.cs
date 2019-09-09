using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex02_Othelo
{
    public partial class FormSetting : Form
    {
        public int SizeOfBoard { get; set; }

        public Game m_Game = new Game();

        public FormSetting()
        {
            InitializeComponent();
            SizeOfBoard = 6;
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {

        }

        private void BoardSizeButton_Click(object sender, EventArgs e)
        {
            if (SizeOfBoard == 12)
            {
                SizeOfBoard = 6;
            }
            else
            {
                SizeOfBoard += 2;
            }

            BoardSizeButton.Text = string.Format("Board size: {0}x{0} (click to increase)", SizeOfBoard);
        }

        private void PlayAgainstFriendButton_Click(object sender, EventArgs e)
        {
            m_Game.SetPlayer(1, "Player One");
            m_Game.SetPlayer(2, "Player Two");
            this.Hide();
            OthelloGameForm othelloGameForm = new OthelloGameForm(SizeOfBoard, m_Game);

            othelloGameForm.ShowDialog();
            this.Close();
        }

        private void PlayAgainstComputerButton_Click(object sender, EventArgs e)
        {
            m_Game.SetPlayer(1, "Player One");
            m_Game.SetPlayer(2, "computer");
            this.Hide();
            OthelloGameForm othelloGameForm = new OthelloGameForm(SizeOfBoard, m_Game);
            othelloGameForm.ShowDialog();
            this.Close();
        }

        private void SettingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
