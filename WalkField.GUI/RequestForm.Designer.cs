namespace WalkField.GUI
{
    partial class RequestForm
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
            AcceptBtn = new Button();
            DeclineBtn = new Button();
            AddrLabel = new Label();
            SuspendLayout();
            // 
            // AcceptBtn
            // 
            AcceptBtn.Location = new Point(75, 127);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(75, 23);
            AcceptBtn.TabIndex = 0;
            AcceptBtn.Text = "Accept";
            AcceptBtn.UseVisualStyleBackColor = true;
            // 
            // DeclineBtn
            // 
            DeclineBtn.Location = new Point(257, 127);
            DeclineBtn.Name = "DeclineBtn";
            DeclineBtn.Size = new Size(75, 23);
            DeclineBtn.TabIndex = 0;
            DeclineBtn.Text = "Decline";
            DeclineBtn.UseVisualStyleBackColor = true;
            // 
            // AddrLabel
            // 
            AddrLabel.AutoSize = true;
            AddrLabel.Location = new Point(124, 67);
            AddrLabel.Name = "AddrLabel";
            AddrLabel.Size = new Size(159, 15);
            AddrLabel.TabIndex = 1;
            AddrLabel.Text = "Someone send you a request";
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 197);
            Controls.Add(AddrLabel);
            Controls.Add(DeclineBtn);
            Controls.Add(AcceptBtn);
            Name = "RequestForm";
            Text = "Connection request";
            Load += RequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AcceptBtn;
        private Button DeclineBtn;
        private Label AddrLabel;
    }
}