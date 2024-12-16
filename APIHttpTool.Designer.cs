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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "API URL :";
            // 
            // txtApiUrl
            // 
            txtApiUrl.Location = new Point(12, 42);
            txtApiUrl.Name = "txtApiUrl";
            txtApiUrl.Size = new Size(225, 23);
            txtApiUrl.TabIndex = 1;
            // 
            // rtbResponse
            // 
            rtbResponse.Location = new Point(264, 42);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.Size = new Size(148, 23);
            rtbResponse.TabIndex = 2;
            rtbResponse.Text = "Send Get Request";
            rtbResponse.UseVisualStyleBackColor = true;
            // 
            // APIHttpTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
