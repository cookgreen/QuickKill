﻿namespace QuickKill
{
    partial class frmAIApiSetup
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
            picBanner = new PictureBox();
            label1 = new Label();
            txtAPI = new TextBox();
            btnCancel = new Button();
            btnOK = new Button();
            cmbProviders = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            SuspendLayout();
            // 
            // picBanner
            // 
            picBanner.Image = Properties.Resources.deepseek_logo;
            picBanner.Location = new Point(12, 12);
            picBanner.Name = "picBanner";
            picBanner.Size = new Size(467, 265);
            picBanner.SizeMode = PictureBoxSizeMode.Zoom;
            picBanner.TabIndex = 0;
            picBanner.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 287);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "API:";
            // 
            // txtAPI
            // 
            txtAPI.Location = new Point(55, 284);
            txtAPI.Name = "txtAPI";
            txtAPI.Size = new Size(302, 27);
            txtAPI.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(363, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 47);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(229, 455);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(116, 47);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // cmbProviders
            // 
            cmbProviders.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProviders.FormattingEnabled = true;
            cmbProviders.Items.AddRange(new object[] { "DeepSeek", "Nvidia", "Grok" });
            cmbProviders.Location = new Point(363, 283);
            cmbProviders.Name = "cmbProviders";
            cmbProviders.Size = new Size(116, 28);
            cmbProviders.TabIndex = 5;
            cmbProviders.SelectedIndexChanged += cmbProviders_SelectedIndexChanged;
            // 
            // frmAIApiSetup
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 514);
            Controls.Add(cmbProviders);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(txtAPI);
            Controls.Add(label1);
            Controls.Add(picBanner);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAIApiSetup";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI API Setup";
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBanner;
        private Label label1;
        private TextBox txtAPI;
        private Button btnCancel;
        private Button btnOK;
        private ComboBox cmbProviders;
    }
}