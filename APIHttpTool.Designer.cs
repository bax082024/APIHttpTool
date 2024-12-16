namespace APIHttpTool
{
    partial class APIHttpTool
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
            label1 = new Label();
            txtApiUrl = new TextBox();
            rtbResponse = new Button();
            rtbLogs = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "API URL :";
            // 
            // txtApiUrl
            // 
            txtApiUrl.Location = new Point(12, 42);
            txtApiUrl.Name = "txtApiUrl";
            txtApiUrl.Size = new Size(309, 23);
            txtApiUrl.TabIndex = 1;
            // 
            // rtbResponse
            // 
            rtbResponse.Location = new Point(12, 82);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.Size = new Size(309, 35);
            rtbResponse.TabIndex = 2;
            rtbResponse.Text = "Send Get Request";
            rtbResponse.UseVisualStyleBackColor = true;
            // 
            // rtbLogs
            // 
            rtbLogs.Location = new Point(377, 24);
            rtbLogs.Name = "rtbLogs";
            rtbLogs.Size = new Size(484, 142);
            rtbLogs.TabIndex = 3;
            rtbLogs.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(377, 181);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(484, 142);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(377, 343);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(484, 142);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(377, 508);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(484, 142);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 233);
            button1.Name = "button1";
            button1.Size = new Size(309, 35);
            button1.TabIndex = 7;
            button1.Text = "Send Get Request";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 392);
            button2.Name = "button2";
            button2.Size = new Size(309, 35);
            button2.TabIndex = 8;
            button2.Text = "Send Get Request";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 559);
            button3.Name = "button3";
            button3.Size = new Size(309, 35);
            button3.TabIndex = 9;
            button3.Text = "Send Get Request";
            button3.UseVisualStyleBackColor = true;
            // 
            // APIHttpTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 680);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(rtbLogs);
            Controls.Add(rtbResponse);
            Controls.Add(txtApiUrl);
            Controls.Add(label1);
            Name = "APIHttpTool";
            Text = "API Http Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApiUrl;
        private Button rtbResponse;
        private RichTextBox rtbLogs;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
