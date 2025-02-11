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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lbBalance = new Label();
            timer = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            mnuTool = new ToolStripMenuItem();
            mnuToolChat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(642, 35);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Balance:";
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.Location = new Point(756, 40);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(18, 20);
            lbBalance.TabIndex = 1;
            lbBalance.Text = "0";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuTool });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
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
            mnuFileExit.Size = new Size(224, 26);
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
            mnuToolChat.Size = new Size(224, 26);
            mnuToolChat.Text = "Chat";
            mnuToolChat.Click += mnuToolChat_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(lbBalance);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuickKill Analyzer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbBalance;
        private System.Windows.Forms.Timer timer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuTool;
        private ToolStripMenuItem mnuToolChat;
    }
}
