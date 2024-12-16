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
            btnSendGet = new Button();
            rtbResponse1 = new RichTextBox();
            rtbResponsePost = new RichTextBox();
            rtbResponsePut = new RichTextBox();
            rtbResponseDelete = new RichTextBox();
            btnSendPost = new Button();
            btnSendPut = new Button();
            btnSendDelete = new Button();
            txtApiUrlPost = new TextBox();
            label2 = new Label();
            txtApiUrlPut = new TextBox();
            label3 = new Label();
            txtApiUrlDelete = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "API URL :";
            // 
            // txtApiUrl1
            // 
            txtApiUrl1.Location = new Point(12, 74);
            txtApiUrl1.Name = "txtApiUrl1";
            txtApiUrl1.Size = new Size(309, 23);
            txtApiUrl1.TabIndex = 1;
            // 
            // btnSendGet
            // 
            btnSendGet.Location = new Point(12, 114);
            btnSendGet.Name = "btnSendGet";
            btnSendGet.Size = new Size(309, 35);
            btnSendGet.TabIndex = 2;
            btnSendGet.Text = "Send GET Request";
            btnSendGet.UseVisualStyleBackColor = true;
            btnSendGet.Click += btnSendGet_Click;
            // 
            // rtbResponse1
            // 
            rtbResponse1.Location = new Point(377, 24);
            rtbResponse1.Name = "rtbResponse1";
            rtbResponse1.Size = new Size(484, 142);
            rtbResponse1.TabIndex = 3;
            rtbResponse1.Text = "";
            // 
            // rtbResponsePost
            // 
            rtbResponsePost.Location = new Point(377, 181);
            rtbResponsePost.Name = "rtbResponsePost";
            rtbResponsePost.Size = new Size(484, 142);
            rtbResponsePost.TabIndex = 4;
            rtbResponsePost.Text = "";
            // 
            // rtbResponsePut
            // 
            rtbResponsePut.Location = new Point(377, 343);
            rtbResponsePut.Name = "rtbResponsePut";
            rtbResponsePut.Size = new Size(484, 142);
            rtbResponsePut.TabIndex = 5;
            rtbResponsePut.Text = "";
            // 
            // rtbResponseDelete
            // 
            rtbResponseDelete.Location = new Point(377, 508);
            rtbResponseDelete.Name = "rtbResponseDelete";
            rtbResponseDelete.Size = new Size(484, 142);
            rtbResponseDelete.TabIndex = 6;
            rtbResponseDelete.Text = "";
            // 
            // btnSendPost
            // 
            btnSendPost.Location = new Point(12, 273);
            btnSendPost.Name = "btnSendPost";
            btnSendPost.Size = new Size(309, 35);
            btnSendPost.TabIndex = 7;
            btnSendPost.Text = "Send POST Request";
            btnSendPost.UseVisualStyleBackColor = true;
            btnSendPost.Click += btnSendPost_Click;
            // 
            // btnSendPut
            // 
            btnSendPut.Location = new Point(12, 437);
            btnSendPut.Name = "btnSendPut";
            btnSendPut.Size = new Size(309, 35);
            btnSendPut.TabIndex = 8;
            btnSendPut.Text = "Send PUT Request";
            btnSendPut.UseVisualStyleBackColor = true;
            btnSendPut.Click += btnSendPut_Click;
            // 
            // btnSendDelete
            // 
            btnSendDelete.Location = new Point(12, 612);
            btnSendDelete.Name = "btnSendDelete";
            btnSendDelete.Size = new Size(309, 35);
            btnSendDelete.TabIndex = 9;
            btnSendDelete.Text = "Send DELETE Request";
            btnSendDelete.UseVisualStyleBackColor = true;
            btnSendDelete.Click += btnSendDelete_Click;
            // 
            // txtApiUrlPost
            // 
            txtApiUrlPost.Location = new Point(12, 234);
            txtApiUrlPost.Name = "txtApiUrlPost";
            txtApiUrlPost.Size = new Size(309, 23);
            txtApiUrlPost.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 216);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "API URL :";
            // 
            // txtApiUrlPut
            // 
            txtApiUrlPut.Location = new Point(12, 388);
            txtApiUrlPut.Name = "txtApiUrlPut";
            txtApiUrlPut.Size = new Size(309, 23);
            txtApiUrlPut.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 370);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "API URL :";
            // 
            // txtApiUrlDelete
            // 
            txtApiUrlDelete.Location = new Point(12, 560);
            txtApiUrlDelete.Name = "txtApiUrlDelete";
            txtApiUrlDelete.Size = new Size(309, 23);
            txtApiUrlDelete.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 542);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 14;
            label4.Text = "API URL :";
            // 
            // APIHttpTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(968, 680);
            Controls.Add(txtApiUrlDelete);
            Controls.Add(label4);
            Controls.Add(txtApiUrlPut);
            Controls.Add(label3);
            Controls.Add(txtApiUrlPost);
            Controls.Add(label2);
            Controls.Add(btnSendDelete);
            Controls.Add(btnSendPut);
            Controls.Add(btnSendPost);
            Controls.Add(rtbResponseDelete);
            Controls.Add(rtbResponsePut);
            Controls.Add(rtbResponsePost);
            Controls.Add(rtbResponse1);
            Controls.Add(btnSendGet);
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
        private Button btnSendGet;
        private RichTextBox rtbResponse1;
        private RichTextBox rtbResponsePost;
        private RichTextBox rtbResponsePut;
        private RichTextBox rtbResponseDelete;
        private Button btnSendPost;
        private Button btnSendPut;
        private Button btnSendDelete;
        private TextBox txtApiUrlPost;
        private Label label2;
        private TextBox txtApiUrlPut;
        private Label label3;
        private TextBox txtApiUrlDelete;
        private Label label4;
    }
}
