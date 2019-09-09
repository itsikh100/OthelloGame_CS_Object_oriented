namespace Ex02_Othelo
{
    public partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.PlayAgainstFriendButton = new System.Windows.Forms.Button();
            this.PlayAgainstComputerButton = new System.Windows.Forms.Button();
            this.BoardSizeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.PlayAgainstFriendButton);
            this.SettingPanel.Controls.Add(this.PlayAgainstComputerButton);
            this.SettingPanel.Controls.Add(this.BoardSizeButton);
            this.SettingPanel.Location = new System.Drawing.Point(12, 12);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(427, 209);
            this.SettingPanel.TabIndex = 0;
            this.SettingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingPanel_Paint);
            // 
            // PlayAgainstFriendButton
            // 
            this.PlayAgainstFriendButton.Location = new System.Drawing.Point(225, 122);
            this.PlayAgainstFriendButton.Name = "PlayAgainstFriendButton";
            this.PlayAgainstFriendButton.Size = new System.Drawing.Size(160, 45);
            this.PlayAgainstFriendButton.TabIndex = 2;
            this.PlayAgainstFriendButton.Text = "Play against your friend";
            this.PlayAgainstFriendButton.UseVisualStyleBackColor = true;
            this.PlayAgainstFriendButton.Click += new System.EventHandler(this.PlayAgainstFriendButton_Click);
            // 
            // PlayAgainstComputerButton
            // 
            this.PlayAgainstComputerButton.Location = new System.Drawing.Point(48, 122);
            this.PlayAgainstComputerButton.Name = "PlayAgainstComputerButton";
            this.PlayAgainstComputerButton.Size = new System.Drawing.Size(160, 45);
            this.PlayAgainstComputerButton.TabIndex = 1;
            this.PlayAgainstComputerButton.Text = "Play against the computer";
            this.PlayAgainstComputerButton.UseVisualStyleBackColor = true;
            this.PlayAgainstComputerButton.Click += new System.EventHandler(this.PlayAgainstComputerButton_Click);
            // 
            // BoardSizeButton
            // 
            this.BoardSizeButton.Location = new System.Drawing.Point(48, 32);
            this.BoardSizeButton.Name = "BoardSizeButton";
            this.BoardSizeButton.Size = new System.Drawing.Size(337, 59);
            this.BoardSizeButton.TabIndex = 0;
            this.BoardSizeButton.Text = "Board size: 6x6 (click to increase)";
            this.BoardSizeButton.UseVisualStyleBackColor = true;
            this.BoardSizeButton.Click += new System.EventHandler(this.BoardSizeButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(558, 407);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 10);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // OthelloGameSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 233);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.SettingPanel);
            this.Name = "OthelloGameSettingForm";
            this.Text = "Othello - Game Setting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.SettingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Button PlayAgainstFriendButton;
        private System.Windows.Forms.Button PlayAgainstComputerButton;
        private System.Windows.Forms.Button BoardSizeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}