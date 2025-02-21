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
            chatList = new ListBox();
            txtChatMessage = new TextBox();
            btnSend = new Button();
            lbSelectModel = new Label();
            cmbModelList = new ComboBox();
            lbBalanceText = new Label();
            lbBalance = new Label();
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
            // lbSelectModel
            // 
            lbSelectModel.AutoSize = true;
            lbSelectModel.Location = new Point(11, 126);
            lbSelectModel.Name = "lbSelectModel";
            lbSelectModel.Size = new Size(110, 20);
            lbSelectModel.TabIndex = 3;
            lbSelectModel.Text = "Select Model:";
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
            // lbBalanceText
            // 
            lbBalanceText.AutoSize = true;
            lbBalanceText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbBalanceText.Location = new Point(450, 123);
            lbBalanceText.Name = "lbBalanceText";
            lbBalanceText.Size = new Size(97, 27);
            lbBalanceText.TabIndex = 5;
            lbBalanceText.Text = "Balance:";
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
            Controls.Add(lbBalanceText);
            Controls.Add(cmbModelList);
            Controls.Add(lbSelectModel);
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
            Text = "Chat with AI";
            FormClosing += frmDeepSeekChat_FormClosing;
            Load += frmDeepSeekChat_Load;
            ((System.ComponentModel.ISupportInitialize)picHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox chatList;
        private TextBox txtChatMessage;
        private Button btnSend;
        private Label lbSelectModel;
        private ComboBox cmbModelList;
        private Label lbBalanceText;
        private Label lbBalance;
        private PictureBox picHeader;
    }
}