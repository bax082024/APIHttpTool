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
            txtHeaderKeyGet = new TextBox();
            txtHeaderValueGet = new TextBox();
            txtHeaderKeyPost = new TextBox();
            txtHeaderValuePost = new TextBox();
            txtHeaderKeyPut = new TextBox();
            txtHeaderValuePut = new TextBox();
            txtHeaderKeyDelete = new TextBox();
            txtHeaderValueDelete = new TextBox();
            btnResetHeadersDelete = new Button();
            lblHeader = new Label();
            label5 = new Label();
            label6 = new Label();
            btnResetHeadersGet = new Button();
            btnResetHeadersPost = new Button();
            btnResetHeadersPut = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 55);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 0;
            label1.Text = "API URL :";
            // 
            // txtApiUrl1
            // 
            txtApiUrl1.BackColor = SystemColors.Info;
            txtApiUrl1.Location = new Point(12, 75);
            txtApiUrl1.Name = "txtApiUrl1";
            txtApiUrl1.Size = new Size(309, 23);
            txtApiUrl1.TabIndex = 1;
            // 
            // btnSendGet
            // 
            btnSendGet.BackColor = Color.LightGreen;
            btnSendGet.FlatStyle = FlatStyle.Flat;
            btnSendGet.Location = new Point(13, 113);
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
            rtbResponse1.BorderStyle = BorderStyle.FixedSingle;
            rtbResponse1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbResponse1.Location = new Point(377, 38);
            rtbResponse1.Name = "rtbResponse1";
            rtbResponse1.Size = new Size(303, 142);
            rtbResponse1.TabIndex = 3;
            rtbResponse1.Text = "";
            // 
            // rtbResponsePost
            // 
            rtbResponsePost.BackColor = SystemColors.Info;
            rtbResponsePost.Font = new Font("Courier New", 9.75F);
            rtbResponsePost.Location = new Point(377, 211);
            rtbResponsePost.Name = "rtbResponsePost";
            rtbResponsePost.Size = new Size(303, 142);
            rtbResponsePost.TabIndex = 4;
            rtbResponsePost.Text = "";
            // 
            // rtbResponsePut
            // 
            rtbResponsePut.BackColor = SystemColors.Info;
            rtbResponsePut.Font = new Font("Courier New", 9.75F);
            rtbResponsePut.Location = new Point(377, 385);
            rtbResponsePut.Name = "rtbResponsePut";
            rtbResponsePut.Size = new Size(303, 142);
            rtbResponsePut.TabIndex = 5;
            rtbResponsePut.Text = "";
            // 
            // rtbResponseDelete
            // 
            rtbResponseDelete.BackColor = SystemColors.Info;
            rtbResponseDelete.Font = new Font("Courier New", 9.75F);
            rtbResponseDelete.Location = new Point(377, 562);
            rtbResponseDelete.Name = "rtbResponseDelete";
            rtbResponseDelete.Size = new Size(303, 142);
            rtbResponseDelete.TabIndex = 6;
            rtbResponseDelete.Text = "";
            // 
            // btnSendPost
            // 
            btnSendPost.BackColor = Color.SkyBlue;
            btnSendPost.FlatStyle = FlatStyle.Flat;
            btnSendPost.Location = new Point(13, 289);
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
            btnSendPut.FlatStyle = FlatStyle.Flat;
            btnSendPut.Location = new Point(12, 456);
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
            btnSendDelete.FlatStyle = FlatStyle.Flat;
            btnSendDelete.Location = new Point(12, 638);
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
            txtApiUrlPost.Location = new Point(12, 251);
            txtApiUrlPost.Name = "txtApiUrlPost";
            txtApiUrlPost.Size = new Size(309, 23);
            txtApiUrlPost.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(123, 231);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 10;
            label2.Text = "API URL :";
            // 
            // txtApiUrlPut
            // 
            txtApiUrlPut.BackColor = SystemColors.Info;
            txtApiUrlPut.Location = new Point(12, 417);
            txtApiUrlPut.Name = "txtApiUrlPut";
            txtApiUrlPut.Size = new Size(309, 23);
            txtApiUrlPut.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(123, 397);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 12;
            label3.Text = "API URL :";
            // 
            // txtApiUrlDelete
            // 
            txtApiUrlDelete.BackColor = SystemColors.Info;
            txtApiUrlDelete.Location = new Point(12, 600);
            txtApiUrlDelete.Name = "txtApiUrlDelete";
            txtApiUrlDelete.Size = new Size(309, 23);
            txtApiUrlDelete.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(123, 580);
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
            button2.Location = new Point(328, 264);
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
            button1.Location = new Point(328, 88);
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
            button3.Location = new Point(328, 430);
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
            button4.Location = new Point(328, 614);
            button4.Name = "button4";
            button4.Size = new Size(43, 37);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // lblStatusCodeDelete
            // 
            lblStatusCodeDelete.AutoSize = true;
            lblStatusCodeDelete.BackColor = Color.Transparent;
            lblStatusCodeDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStatusCodeDelete.Location = new Point(377, 542);
            lblStatusCodeDelete.Name = "lblStatusCodeDelete";
            lblStatusCodeDelete.Size = new Size(108, 17);
            lblStatusCodeDelete.TabIndex = 21;
            lblStatusCodeDelete.Text = "Status: Not Sent";
            // 
            // lblStatusCodePut
            // 
            lblStatusCodePut.AutoSize = true;
            lblStatusCodePut.BackColor = Color.Transparent;
            lblStatusCodePut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStatusCodePut.Location = new Point(377, 365);
            lblStatusCodePut.Name = "lblStatusCodePut";
            lblStatusCodePut.Size = new Size(108, 17);
            lblStatusCodePut.TabIndex = 22;
            lblStatusCodePut.Text = "Status: Not Sent";
            // 
            // lblStatusCodePost
            // 
            lblStatusCodePost.AutoSize = true;
            lblStatusCodePost.BackColor = Color.Transparent;
            lblStatusCodePost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStatusCodePost.Location = new Point(377, 191);
            lblStatusCodePost.Name = "lblStatusCodePost";
            lblStatusCodePost.Size = new Size(108, 17);
            lblStatusCodePost.TabIndex = 23;
            lblStatusCodePost.Text = "Status: Not Sent";
            // 
            // lblStatusCodeGet
            // 
            lblStatusCodeGet.AutoSize = true;
            lblStatusCodeGet.BackColor = Color.Transparent;
            lblStatusCodeGet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStatusCodeGet.Location = new Point(377, 18);
            lblStatusCodeGet.Name = "lblStatusCodeGet";
            lblStatusCodeGet.Size = new Size(108, 17);
            lblStatusCodeGet.TabIndex = 24;
            lblStatusCodeGet.Text = "Status: Not Sent";
            // 
            // txtHeaderKeyGet
            // 
            txtHeaderKeyGet.BackColor = SystemColors.Info;
            txtHeaderKeyGet.Location = new Point(697, 88);
            txtHeaderKeyGet.Name = "txtHeaderKeyGet";
            txtHeaderKeyGet.Size = new Size(150, 23);
            txtHeaderKeyGet.TabIndex = 25;
            // 
            // txtHeaderValueGet
            // 
            txtHeaderValueGet.BackColor = SystemColors.Info;
            txtHeaderValueGet.Location = new Point(866, 88);
            txtHeaderValueGet.Name = "txtHeaderValueGet";
            txtHeaderValueGet.Size = new Size(250, 23);
            txtHeaderValueGet.TabIndex = 26;
            // 
            // txtHeaderKeyPost
            // 
            txtHeaderKeyPost.BackColor = SystemColors.Info;
            txtHeaderKeyPost.Location = new Point(697, 264);
            txtHeaderKeyPost.Name = "txtHeaderKeyPost";
            txtHeaderKeyPost.Size = new Size(150, 23);
            txtHeaderKeyPost.TabIndex = 27;
            // 
            // txtHeaderValuePost
            // 
            txtHeaderValuePost.BackColor = SystemColors.Info;
            txtHeaderValuePost.Location = new Point(866, 264);
            txtHeaderValuePost.Name = "txtHeaderValuePost";
            txtHeaderValuePost.Size = new Size(250, 23);
            txtHeaderValuePost.TabIndex = 28;
            // 
            // txtHeaderKeyPut
            // 
            txtHeaderKeyPut.BackColor = SystemColors.Info;
            txtHeaderKeyPut.Location = new Point(697, 444);
            txtHeaderKeyPut.Name = "txtHeaderKeyPut";
            txtHeaderKeyPut.Size = new Size(150, 23);
            txtHeaderKeyPut.TabIndex = 29;
            // 
            // txtHeaderValuePut
            // 
            txtHeaderValuePut.BackColor = SystemColors.Info;
            txtHeaderValuePut.Location = new Point(866, 444);
            txtHeaderValuePut.Name = "txtHeaderValuePut";
            txtHeaderValuePut.Size = new Size(250, 23);
            txtHeaderValuePut.TabIndex = 30;
            // 
            // txtHeaderKeyDelete
            // 
            txtHeaderKeyDelete.BackColor = SystemColors.Info;
            txtHeaderKeyDelete.Location = new Point(697, 628);
            txtHeaderKeyDelete.Name = "txtHeaderKeyDelete";
            txtHeaderKeyDelete.Size = new Size(150, 23);
            txtHeaderKeyDelete.TabIndex = 31;
            // 
            // txtHeaderValueDelete
            // 
            txtHeaderValueDelete.BackColor = SystemColors.Info;
            txtHeaderValueDelete.Location = new Point(866, 628);
            txtHeaderValueDelete.Name = "txtHeaderValueDelete";
            txtHeaderValueDelete.Size = new Size(250, 23);
            txtHeaderValueDelete.TabIndex = 32;
            // 
            // btnResetHeadersDelete
            // 
            btnResetHeadersDelete.BackColor = Color.Silver;
            btnResetHeadersDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetHeadersDelete.Location = new Point(866, 667);
            btnResetHeadersDelete.Name = "btnResetHeadersDelete";
            btnResetHeadersDelete.Size = new Size(75, 23);
            btnResetHeadersDelete.TabIndex = 36;
            btnResetHeadersDelete.Text = "Reset";
            btnResetHeadersDelete.UseVisualStyleBackColor = false;
            btnResetHeadersDelete.Click += btnResetHeadersDelete_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(834, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(126, 17);
            lblHeader.TabIndex = 37;
            lblHeader.Text = "Headers (Optional)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(753, 55);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 38;
            label5.Text = "Key :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(962, 57);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 39;
            label6.Text = "Header : ";
            // 
            // btnResetHeadersGet
            // 
            btnResetHeadersGet.BackColor = Color.Silver;
            btnResetHeadersGet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetHeadersGet.ImageList = imageList1;
            btnResetHeadersGet.Location = new Point(866, 125);
            btnResetHeadersGet.Name = "btnResetHeadersGet";
            btnResetHeadersGet.Size = new Size(75, 23);
            btnResetHeadersGet.TabIndex = 33;
            btnResetHeadersGet.Text = "Reset";
            btnResetHeadersGet.UseVisualStyleBackColor = false;
            btnResetHeadersGet.Click += btnResetHeadersGet_Click;
            // 
            // btnResetHeadersPost
            // 
            btnResetHeadersPost.BackColor = Color.Silver;
            btnResetHeadersPost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetHeadersPost.Location = new Point(866, 301);
            btnResetHeadersPost.Name = "btnResetHeadersPost";
            btnResetHeadersPost.Size = new Size(75, 23);
            btnResetHeadersPost.TabIndex = 34;
            btnResetHeadersPost.Text = "Reset";
            btnResetHeadersPost.UseVisualStyleBackColor = false;
            btnResetHeadersPost.Click += btnResetHeadersPost_Click;
            // 
            // btnResetHeadersPut
            // 
            btnResetHeadersPut.BackColor = Color.Silver;
            btnResetHeadersPut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetHeadersPut.Location = new Point(866, 484);
            btnResetHeadersPut.Name = "btnResetHeadersPut";
            btnResetHeadersPut.Size = new Size(75, 23);
            btnResetHeadersPut.TabIndex = 35;
            btnResetHeadersPut.Text = "Reset";
            btnResetHeadersPut.UseVisualStyleBackColor = false;
            btnResetHeadersPut.Click += btnResetHeadersPut_Click;
            // 
            // APIHttpTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1138, 731);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblHeader);
            Controls.Add(btnResetHeadersDelete);
            Controls.Add(btnResetHeadersPut);
            Controls.Add(btnResetHeadersPost);
            Controls.Add(btnResetHeadersGet);
            Controls.Add(txtHeaderValueDelete);
            Controls.Add(txtHeaderKeyDelete);
            Controls.Add(txtHeaderValuePut);
            Controls.Add(txtHeaderKeyPut);
            Controls.Add(txtHeaderValuePost);
            Controls.Add(txtHeaderKeyPost);
            Controls.Add(txtHeaderValueGet);
            Controls.Add(txtHeaderKeyGet);
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
        private TextBox txtHeaderKeyGet;
        private TextBox txtHeaderValueGet;
        private TextBox txtHeaderKeyPost;
        private TextBox txtHeaderValuePost;
        private TextBox txtHeaderKeyPut;
        private TextBox txtHeaderValuePut;
        private TextBox txtHeaderKeyDelete;
        private TextBox txtHeaderValueDelete;
        private Button btnResetHeadersDelete;
        private Label lblHeader;
        private Label label5;
        private Label label6;
        private Button btnResetHeadersGet;
        private Button btnResetHeadersPost;
        private Button btnResetHeadersPut;
        private ToolTip toolTip1;
    }
}
