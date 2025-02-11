namespace QuickKill
{
    partial class frmDeepSeekChat
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
            components = new System.ComponentModel.Container();
            chatList = new ListBox();
            txtChatMessage = new TextBox();
            btnSend = new Button();
            label1 = new Label();
            cmbModelList = new ComboBox();
            label2 = new Label();
            lbBalance = new Label();
            timer = new System.Windows.Forms.Timer(components);
            picHeader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picHeader).BeginInit();
            SuspendLayout();
            // 
            // chatList
            // 
            chatList.FormattingEnabled = true;
            chatList.Location = new Point(11, 160);
            chatList.Name = "chatList";
            chatList.Size = new Size(582, 404);
            chatList.TabIndex = 0;
            // 
            // txtChatMessage
            // 
            txtChatMessage.Location = new Point(11, 589);
            txtChatMessage.Name = "txtChatMessage";
            txtChatMessage.Size = new Size(485, 27);
            txtChatMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(502, 582);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(91, 40);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 126);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Select Model:";
            // 
            // cmbModelList
            // 
            cmbModelList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModelList.FormattingEnabled = true;
            cmbModelList.Location = new Point(127, 123);
            cmbModelList.Name = "cmbModelList";
            cmbModelList.Size = new Size(151, 28);
            cmbModelList.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(450, 123);
            label2.Name = "label2";
            label2.Size = new Size(97, 27);
            label2.TabIndex = 5;
            label2.Text = "Balance:";
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.Location = new Point(564, 126);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(18, 20);
            lbBalance.TabIndex = 6;
            lbBalance.Text = "0";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // picHeader
            // 
            picHeader.Image = Properties.Resources.deepseek_header_950x150;
            picHeader.Location = new Point(12, 12);
            picHeader.Name = "picHeader";
            picHeader.Size = new Size(582, 93);
            picHeader.SizeMode = PictureBoxSizeMode.Zoom;
            picHeader.TabIndex = 7;
            picHeader.TabStop = false;
            // 
            // frmDeepSeekChat
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 630);
            Controls.Add(picHeader);
            Controls.Add(lbBalance);
            Controls.Add(label2);
            Controls.Add(cmbModelList);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(txtChatMessage);
            Controls.Add(chatList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDeepSeekChat";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat with DeepSeek";
            ((System.ComponentModel.ISupportInitialize)picHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox chatList;
        private TextBox txtChatMessage;
        private Button btnSend;
        private Label label1;
        private ComboBox cmbModelList;
        private Label label2;
        private Label lbBalance;
        private System.Windows.Forms.Timer timer;
        private PictureBox picHeader;
    }
}