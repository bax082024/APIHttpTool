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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIHttpTool));
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
            imageList1 = new ImageList(components);
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            lblStatusCodeDelete = new Label();
            lblStatusCodePut = new Label();
            lblStatusCodePost = new Label();
            lblStatusCodeGet = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 68);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 0;
            label1.Text = "API URL :";
            // 
            // txtApiUrl1
            // 
            txtApiUrl1.BackColor = SystemColors.Info;
            txtApiUrl1.Location = new Point(12, 88);
            txtApiUrl1.Name = "txtApiUrl1";
            txtApiUrl1.Size = new Size(309, 23);
            txtApiUrl1.TabIndex = 1;
            // 
            // btnSendGet
            // 
            btnSendGet.BackColor = Color.LightGreen;
            btnSendGet.Location = new Point(12, 128);
            btnSendGet.Name = "btnSendGet";
            btnSendGet.Size = new Size(309, 35);
            btnSendGet.TabIndex = 2;
            btnSendGet.Text = "Send GET Request";
            btnSendGet.UseVisualStyleBackColor = false;
            btnSendGet.Click += btnSendGet_Click;
            // 
            // rtbResponse1
            // 
            rtbResponse1.BackColor = SystemColors.Info;
            rtbResponse1.Location = new Point(377, 38);
            rtbResponse1.Name = "rtbResponse1";
            rtbResponse1.Size = new Size(484, 142);
            rtbResponse1.TabIndex = 3;
            rtbResponse1.Text = "";
            // 
            // rtbResponsePost
            // 
            rtbResponsePost.BackColor = SystemColors.Info;
            rtbResponsePost.Location = new Point(377, 211);
            rtbResponsePost.Name = "rtbResponsePost";
            rtbResponsePost.Size = new Size(484, 142);
            rtbResponsePost.TabIndex = 4;
            rtbResponsePost.Text = "";
            // 
            // rtbResponsePut
            // 
            rtbResponsePut.BackColor = SystemColors.Info;
            rtbResponsePut.Location = new Point(377, 385);
            rtbResponsePut.Name = "rtbResponsePut";
            rtbResponsePut.Size = new Size(484, 142);
            rtbResponsePut.TabIndex = 5;
            rtbResponsePut.Text = "";
            // 
            // rtbResponseDelete
            // 
            rtbResponseDelete.BackColor = SystemColors.Info;
            rtbResponseDelete.Location = new Point(377, 562);
            rtbResponseDelete.Name = "rtbResponseDelete";
            rtbResponseDelete.Size = new Size(484, 142);
            rtbResponseDelete.TabIndex = 6;
            rtbResponseDelete.Text = "";
            // 
            // btnSendPost
            // 
            btnSendPost.BackColor = Color.SkyBlue;
            btnSendPost.Location = new Point(12, 303);
            btnSendPost.Name = "btnSendPost";
            btnSendPost.Size = new Size(309, 35);
            btnSendPost.TabIndex = 7;
            btnSendPost.Text = "Send POST Request";
            btnSendPost.UseVisualStyleBackColor = false;
            btnSendPost.Click += btnSendPost_Click;
            // 
            // btnSendPut
            // 
            btnSendPut.BackColor = Color.Khaki;
            btnSendPut.Location = new Point(12, 479);
            btnSendPut.Name = "btnSendPut";
            btnSendPut.Size = new Size(309, 35);
            btnSendPut.TabIndex = 8;
            btnSendPut.Text = "Send PUT Request";
            btnSendPut.UseVisualStyleBackColor = false;
            btnSendPut.Click += btnSendPut_Click;
            // 
            // btnSendDelete
            // 
            btnSendDelete.BackColor = Color.LightCoral;
            btnSendDelete.Location = new Point(12, 666);
            btnSendDelete.Name = "btnSendDelete";
            btnSendDelete.Size = new Size(309, 35);
            btnSendDelete.TabIndex = 9;
            btnSendDelete.Text = "Send DELETE Request";
            btnSendDelete.UseVisualStyleBackColor = false;
            btnSendDelete.Click += btnSendDelete_Click;
            // 
            // txtApiUrlPost
            // 
            txtApiUrlPost.BackColor = SystemColors.Info;
            txtApiUrlPost.Location = new Point(12, 264);
            txtApiUrlPost.Name = "txtApiUrlPost";
            txtApiUrlPost.Size = new Size(309, 23);
            txtApiUrlPost.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(123, 244);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 10;
            label2.Text = "API URL :";
            // 
            // txtApiUrlPut
            // 
            txtApiUrlPut.BackColor = SystemColors.Info;
            txtApiUrlPut.Location = new Point(12, 430);
            txtApiUrlPut.Name = "txtApiUrlPut";
            txtApiUrlPut.Size = new Size(309, 23);
            txtApiUrlPut.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(123, 410);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 12;
            label3.Text = "API URL :";
            // 
            // txtApiUrlDelete
            // 
            txtApiUrlDelete.BackColor = SystemColors.Info;
            txtApiUrlDelete.Location = new Point(12, 614);
            txtApiUrlDelete.Name = "txtApiUrlDelete";
            txtApiUrlDelete.Size = new Size(309, 23);
            txtApiUrlDelete.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(123, 594);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 14;
            label4.Text = "API URL :";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "refresh");
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.ImageIndex = 0;
            button2.ImageList = imageList1;
            button2.Location = new Point(327, 430);
            button2.Name = "button2";
            button2.Size = new Size(43, 37);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new Point(328, 264);
            button1.Name = "button1";
            button1.Size = new Size(43, 37);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.ImageIndex = 0;
            button3.ImageList = imageList1;
            button3.Location = new Point(327, 614);
            button3.Name = "button3";
            button3.Size = new Size(43, 37);
            button3.TabIndex = 19;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.ImageIndex = 0;
            button4.ImageList = imageList1;
            button4.Location = new Point(327, 88);
            button4.Name = "button4";
            button4.Size = new Size(43, 37);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // lblStatusCodeDelete
            // 
            lblStatusCodeDelete.AutoSize = true;
            lblStatusCodeDelete.Location = new Point(377, 544);
            lblStatusCodeDelete.Name = "lblStatusCodeDelete";
            lblStatusCodeDelete.Size = new Size(38, 15);
            lblStatusCodeDelete.TabIndex = 21;
            lblStatusCodeDelete.Text = "label5";
            // 
            // lblStatusCodePut
            // 
            lblStatusCodePut.AutoSize = true;
            lblStatusCodePut.Location = new Point(377, 367);
            lblStatusCodePut.Name = "lblStatusCodePut";
            lblStatusCodePut.Size = new Size(38, 15);
            lblStatusCodePut.TabIndex = 22;
            lblStatusCodePut.Text = "label6";
            // 
            // lblStatusCodePost
            // 
            lblStatusCodePost.AutoSize = true;
            lblStatusCodePost.Location = new Point(377, 193);
            lblStatusCodePost.Name = "lblStatusCodePost";
            lblStatusCodePost.Size = new Size(38, 15);
            lblStatusCodePost.TabIndex = 23;
            lblStatusCodePost.Text = "label7";
            // 
            // lblStatusCodeGet
            // 
            lblStatusCodeGet.AutoSize = true;
            lblStatusCodeGet.Location = new Point(377, 20);
            lblStatusCodeGet.Name = "lblStatusCodeGet";
            lblStatusCodeGet.Size = new Size(38, 15);
            lblStatusCodeGet.TabIndex = 24;
            lblStatusCodeGet.Text = "label8";
            // 
            // APIHttpTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(989, 716);
            Controls.Add(lblStatusCodeGet);
            Controls.Add(lblStatusCodePost);
            Controls.Add(lblStatusCodePut);
            Controls.Add(lblStatusCodeDelete);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
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
            Load += APIHttpTool_Load_1;
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
        private ImageList imageList1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label lblStatusCodeDelete;
        private Label lblStatusCodePut;
        private Label lblStatusCodePost;
        private Label lblStatusCodeGet;
    }
}
