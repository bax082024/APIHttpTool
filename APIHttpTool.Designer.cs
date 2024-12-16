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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "API URL :";
            // 
            // txtApiUrl
            // 
            txtApiUrl.Location = new Point(12, 46);
            txtApiUrl.Name = "txtApiUrl";
            txtApiUrl.Size = new Size(309, 23);
            txtApiUrl.TabIndex = 1;
            // 
            // rtbResponse
            // 
            rtbResponse.Location = new Point(12, 86);
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
            button1.Location = new Point(12, 241);
            button1.Name = "button1";
            button1.Size = new Size(309, 35);
            button1.TabIndex = 7;
            button1.Text = "Send Get Request";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 413);
            button2.Name = "button2";
            button2.Size = new Size(309, 35);
            button2.TabIndex = 8;
            button2.Text = "Send Get Request";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 582);
            button3.Name = "button3";
            button3.Size = new Size(309, 35);
            button3.TabIndex = 9;
            button3.Text = "Send Get Request";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 184);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "API URL :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 364);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 346);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "API URL :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 530);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 23);
            textBox3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 512);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 14;
            label4.Text = "API URL :";
            // 
            // APIHttpTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 680);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}
