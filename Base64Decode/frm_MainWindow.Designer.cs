namespace Base64Decode
{
    partial class frm_MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainWindow));
            this.btn_DecodeBase64Garbage = new System.Windows.Forms.Button();
            this.gb_Input = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_Base64_Input = new System.Windows.Forms.RichTextBox();
            this.rtb_Base64_Output = new System.Windows.Forms.RichTextBox();
            this.gb_Input.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DecodeBase64Garbage
            // 
            this.btn_DecodeBase64Garbage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DecodeBase64Garbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DecodeBase64Garbage.Location = new System.Drawing.Point(12, 225);
            this.btn_DecodeBase64Garbage.Name = "btn_DecodeBase64Garbage";
            this.btn_DecodeBase64Garbage.Size = new System.Drawing.Size(758, 36);
            this.btn_DecodeBase64Garbage.TabIndex = 2;
            this.btn_DecodeBase64Garbage.Text = "Decode Base64";
            this.btn_DecodeBase64Garbage.UseVisualStyleBackColor = true;
            this.btn_DecodeBase64Garbage.Click += new System.EventHandler(this.btn_DecodeBase64Garbage_Click);
            // 
            // gb_Input
            // 
            this.gb_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Input.Controls.Add(this.rtb_Base64_Input);
            this.gb_Input.Location = new System.Drawing.Point(12, 12);
            this.gb_Input.Name = "gb_Input";
            this.gb_Input.Size = new System.Drawing.Size(758, 207);
            this.gb_Input.TabIndex = 3;
            this.gb_Input.TabStop = false;
            this.gb_Input.Text = "Paste your Base64 Garbage Here";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtb_Base64_Output);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decoded Results";
            // 
            // rtb_Base64_Input
            // 
            this.rtb_Base64_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Base64_Input.Location = new System.Drawing.Point(6, 21);
            this.rtb_Base64_Input.Name = "rtb_Base64_Input";
            this.rtb_Base64_Input.Size = new System.Drawing.Size(746, 180);
            this.rtb_Base64_Input.TabIndex = 0;
            this.rtb_Base64_Input.Text = "";
            // 
            // rtb_Base64_Output
            // 
            this.rtb_Base64_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Base64_Output.Location = new System.Drawing.Point(6, 21);
            this.rtb_Base64_Output.Name = "rtb_Base64_Output";
            this.rtb_Base64_Output.ReadOnly = true;
            this.rtb_Base64_Output.Size = new System.Drawing.Size(746, 248);
            this.rtb_Base64_Output.TabIndex = 1;
            this.rtb_Base64_Output.Text = "";
            // 
            // frm_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Input);
            this.Controls.Add(this.btn_DecodeBase64Garbage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MainWindow";
            this.Text = "Base64 Decoder";
            this.gb_Input.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DecodeBase64Garbage;
        private System.Windows.Forms.GroupBox gb_Input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_Base64_Input;
        private System.Windows.Forms.RichTextBox rtb_Base64_Output;
    }
}

