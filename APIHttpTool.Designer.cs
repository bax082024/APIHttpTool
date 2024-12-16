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
            txtApiUrl1 = new TextBox();
            btnSendGet1 = new Button();
            rtbResponse1 = new RichTextBox();
            rtbResponse2 = new RichTextBox();
            rtbResponse3 = new RichTextBox();
            rtbResponse4 = new RichTextBox();
            btnSendGet2 = new Button();
            btnSendGet3 = new Button();
            btnSendGet4 = new Button();
            txtApiUrl2 = new TextBox();
            label2 = new Label();
            txtApiUrl3 = new TextBox();
            label3 = new Label();
            txtApiUrl4 = new TextBox();
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
            // txtApiUrl1
            // 
            txtApiUrl1.Location = new Point(12, 46);
            txtApiUrl1.Name = "txtApiUrl1";
            txtApiUrl1.Size = new Size(309, 23);
            txtApiUrl1.TabIndex = 1;
            // 
            // btnSendGet1
            // 
            btnSendGet1.Location = new Point(12, 86);
            btnSendGet1.Name = "btnSendGet1";
            btnSendGet1.Size = new Size(309, 35);
            btnSendGet1.TabIndex = 2;
            btnSendGet1.Text = "Send GET Request";
            btnSendGet1.UseVisualStyleBackColor = true;
            btnSendGet1.Click += btnSendGet1_Click;
            // 
            // rtbResponse1
            // 
            rtbResponse1.Location = new Point(377, 24);
            rtbResponse1.Name = "rtbResponse1";
            rtbResponse1.Size = new Size(484, 142);
            rtbResponse1.TabIndex = 3;
            rtbResponse1.Text = "";
            // 
            // rtbResponse2
            // 
            rtbResponse2.Location = new Point(377, 181);
            rtbResponse2.Name = "rtbResponse2";
            rtbResponse2.Size = new Size(484, 142);
            rtbResponse2.TabIndex = 4;
            rtbResponse2.Text = "";
            // 
            // rtbResponse3
            // 
            rtbResponse3.Location = new Point(377, 343);
            rtbResponse3.Name = "rtbResponse3";
            rtbResponse3.Size = new Size(484, 142);
            rtbResponse3.TabIndex = 5;
            rtbResponse3.Text = "";
            // 
            // rtbResponse4
            // 
            rtbResponse4.Location = new Point(377, 508);
            rtbResponse4.Name = "rtbResponse4";
            rtbResponse4.Size = new Size(484, 142);
            rtbResponse4.TabIndex = 6;
            rtbResponse4.Text = "";
            // 
            // btnSendGet2
            // 
            btnSendGet2.Location = new Point(12, 241);
            btnSendGet2.Name = "btnSendGet2";
            btnSendGet2.Size = new Size(309, 35);
            btnSendGet2.TabIndex = 7;
            btnSendGet2.Text = "Send POST Request";
            btnSendGet2.UseVisualStyleBackColor = true;
            // 
            // btnSendGet3
            // 
            btnSendGet3.Location = new Point(12, 413);
            btnSendGet3.Name = "btnSendGet3";
            btnSendGet3.Size = new Size(309, 35);
            btnSendGet3.TabIndex = 8;
            btnSendGet3.Text = "Send PUT Request";
            btnSendGet3.UseVisualStyleBackColor = true;
            // 
            // btnSendGet4
            // 
            btnSendGet4.Location = new Point(12, 582);
            btnSendGet4.Name = "btnSendGet4";
            btnSendGet4.Size = new Size(309, 35);
            btnSendGet4.TabIndex = 9;
            btnSendGet4.Text = "Send DELETE Request";
            btnSendGet4.UseVisualStyleBackColor = true;
            // 
            // txtApiUrl2
            // 
            txtApiUrl2.Location = new Point(12, 202);
            txtApiUrl2.Name = "txtApiUrl2";
            txtApiUrl2.Size = new Size(309, 23);
            txtApiUrl2.TabIndex = 11;
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
            // txtApiUrl3
            // 
            txtApiUrl3.Location = new Point(12, 364);
            txtApiUrl3.Name = "txtApiUrl3";
            txtApiUrl3.Size = new Size(309, 23);
            txtApiUrl3.TabIndex = 13;
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
            // txtApiUrl4
            // 
            txtApiUrl4.Location = new Point(12, 530);
            txtApiUrl4.Name = "txtApiUrl4";
            txtApiUrl4.Size = new Size(309, 23);
            txtApiUrl4.TabIndex = 15;
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
            Controls.Add(txtApiUrl4);
            Controls.Add(label4);
            Controls.Add(txtApiUrl3);
            Controls.Add(label3);
            Controls.Add(txtApiUrl2);
            Controls.Add(label2);
            Controls.Add(btnSendGet4);
            Controls.Add(btnSendGet3);
            Controls.Add(btnSendGet2);
            Controls.Add(rtbResponse4);
            Controls.Add(rtbResponse3);
            Controls.Add(rtbResponse2);
            Controls.Add(rtbResponse1);
            Controls.Add(btnSendGet1);
            Controls.Add(txtApiUrl1);
            Controls.Add(label1);
            Name = "APIHttpTool";
            Text = "API Http Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApiUrl1;
        private Button btnSendGet1;
        private RichTextBox rtbResponse1;
        private RichTextBox rtbResponse2;
        private RichTextBox rtbResponse3;
        private RichTextBox rtbResponse4;
        private Button btnSendGet2;
        private Button btnSendGet3;
        private Button btnSendGet4;
        private TextBox txtApiUrl2;
        private Label label2;
        private TextBox txtApiUrl3;
        private Label label3;
        private TextBox txtApiUrl4;
        private Label label4;
    }
}
