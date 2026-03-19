namespace EchoMessenger
{
    partial class Form1
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
            labelEchoMessenger = new Label();
            btnSend = new Button();
            lbChatLog = new ListBox();
            txtMessege = new TextBox();
            lblCount = new Label();
            SuspendLayout();
            // 
            // labelEchoMessenger
            // 
            labelEchoMessenger.Cursor = Cursors.No;
            labelEchoMessenger.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelEchoMessenger.ForeColor = SystemColors.Highlight;
            labelEchoMessenger.ImageAlign = ContentAlignment.MiddleRight;
            labelEchoMessenger.Location = new Point(12, 9);
            labelEchoMessenger.Name = "labelEchoMessenger";
            labelEchoMessenger.Size = new Size(481, 86);
            labelEchoMessenger.TabIndex = 0;
            labelEchoMessenger.Text = "Echo Messenger";
            labelEchoMessenger.TextAlign = ContentAlignment.MiddleCenter;
            labelEchoMessenger.Click += labelEchoMessenger_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(128, 255, 128);
            btnSend.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(1242, 761);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(274, 107);
            btnSend.TabIndex = 2;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lbChatLog
            // 
            lbChatLog.FormattingEnabled = true;
            lbChatLog.Location = new Point(40, 116);
            lbChatLog.Name = "lbChatLog";
            lbChatLog.Size = new Size(1476, 580);
            lbChatLog.TabIndex = 3;
            lbChatLog.SelectedIndexChanged += lbChatLog_SelectedIndexChanged;
            // 
            // txtMessege
            // 
            txtMessege.Location = new Point(40, 761);
            txtMessege.Multiline = true;
            txtMessege.Name = "txtMessege";
            txtMessege.Size = new Size(1157, 107);
            txtMessege.TabIndex = 4;
            txtMessege.TextChanged += txtMessege_TextChanged;
            txtMessege.KeyDown += txtMessege_KeyDown;
            // 
            // lblCount
            // 
            lblCount.Location = new Point(40, 715);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(219, 43);
            lblCount.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 960);
            Controls.Add(lblCount);
            Controls.Add(txtMessege);
            Controls.Add(lbChatLog);
            Controls.Add(btnSend);
            Controls.Add(labelEchoMessenger);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEchoMessenger;
        private Button btnSend;
        private ListBox lbChatLog;
        private TextBox txtMessege;
        private Label lblCount;
    }
}
