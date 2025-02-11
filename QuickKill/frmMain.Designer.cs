namespace QuickKill
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbBalanceText = new Label();
            lbBalance = new Label();
            menu = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            mnuTool = new ToolStripMenuItem();
            mnuToolChat = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // lbBalanceText
            // 
            lbBalanceText.AutoSize = true;
            lbBalanceText.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbBalanceText.Location = new Point(1034, 43);
            lbBalanceText.Name = "lbBalanceText";
            lbBalanceText.Size = new Size(85, 25);
            lbBalanceText.TabIndex = 0;
            lbBalanceText.Text = "Balance:";
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.Location = new Point(1131, 46);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(18, 20);
            lbBalance.TabIndex = 1;
            lbBalance.Text = "0";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { mnuFile, mnuTool });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1168, 28);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(48, 24);
            mnuFile.Text = "File";
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(118, 26);
            mnuFileExit.Text = "Exit";
            mnuFileExit.Click += mnuFileExit_Click;
            // 
            // mnuTool
            // 
            mnuTool.DropDownItems.AddRange(new ToolStripItem[] { mnuToolChat });
            mnuTool.Name = "mnuTool";
            mnuTool.Size = new Size(56, 24);
            mnuTool.Text = "Tool";
            // 
            // mnuToolChat
            // 
            mnuToolChat.Name = "mnuToolChat";
            mnuToolChat.Size = new Size(125, 26);
            mnuToolChat.Text = "Chat";
            mnuToolChat.Click += mnuToolChat_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 607);
            Controls.Add(lbBalance);
            Controls.Add(lbBalanceText);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuickKill Analyzer";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBalanceText;
        private Label lbBalance;
        private MenuStrip menu;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuTool;
        private ToolStripMenuItem mnuToolChat;
    }
}
