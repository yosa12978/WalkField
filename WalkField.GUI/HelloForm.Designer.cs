namespace WalkField.GUI
{
    partial class HelloForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SendReqBtn = new Button();
            ReqProcText = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 23);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "My addr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 65);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Rival addr";
            // 
            // SendReqBtn
            // 
            SendReqBtn.Location = new Point(29, 112);
            SendReqBtn.Name = "SendReqBtn";
            SendReqBtn.Size = new Size(112, 23);
            SendReqBtn.TabIndex = 2;
            SendReqBtn.Text = "Send Request";
            SendReqBtn.UseVisualStyleBackColor = true;
            // 
            // ReqProcText
            // 
            ReqProcText.AutoSize = true;
            ReqProcText.Location = new Point(29, 156);
            ReqProcText.Name = "ReqProcText";
            ReqProcText.Size = new Size(118, 15);
            ReqProcText.TabIndex = 3;
            ReqProcText.Text = "Request processing...";
            ReqProcText.Visible = false;
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 198);
            Controls.Add(ReqProcText);
            Controls.Add(SendReqBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "HelloForm";
            Text = "WalkField";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button SendReqBtn;
        private Label ReqProcText;
    }
}