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
            txtMessage = new TextBox();
            lblCount = new Label();
            btnDelete = new Button();
            btnAllDelete = new Button();
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
            txtMessage.Location = new Point(40, 761);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessege";
            txtMessage.Size = new Size(1157, 107);
            txtMessage.TabIndex = 4;
            txtMessage.TextChanged += txtMessage_TextChanged;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // lblCount
            // 
            lblCount.Location = new Point(40, 715);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(219, 43);
            lblCount.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1366, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAllDelete
            // 
            btnAllDelete.Location = new Point(1190, 64);
            btnAllDelete.Name = "btnAllDelete";
            btnAllDelete.Size = new Size(150, 46);
            btnAllDelete.TabIndex = 7;
            btnAllDelete.Text = "전체 삭제";
            btnAllDelete.UseVisualStyleBackColor = true;
            btnAllDelete.Click += btnAllDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 960);
            Controls.Add(btnAllDelete);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(txtMessage);
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
        private TextBox txtMessage;
        private Label lblCount;
        private Button btnDelete;
        private Button btnAllDelete;
    }
}
