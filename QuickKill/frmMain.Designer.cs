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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(640, 13);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Balance:";
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.Location = new Point(749, 16);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(18, 20);
            lbBalance.TabIndex = 1;
            lbBalance.Text = "0";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(lbBalance);
            Controls.Add(label1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuickKill Analyzer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbBalance;
        private System.Windows.Forms.Timer timer;
    }
}
