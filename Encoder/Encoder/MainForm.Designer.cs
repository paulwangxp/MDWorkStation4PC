namespace Encoder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabEncodeType = new System.Windows.Forms.TabControl();
            this.tbpMD5 = new System.Windows.Forms.TabPage();
            this.btnMD5Encrypt = new System.Windows.Forms.Button();
            this.txtMD5Ciphertext = new System.Windows.Forms.TextBox();
            this.lblCiphertext = new System.Windows.Forms.Label();
            this.lblSourceText = new System.Windows.Forms.Label();
            this.txtMD5SourceText = new System.Windows.Forms.TextBox();
            this.tbpDES = new System.Windows.Forms.TabPage();
            this.rdbDESDecrypt = new System.Windows.Forms.RadioButton();
            this.rdbDESEncrypt = new System.Windows.Forms.RadioButton();
            this.tbpRSA = new System.Windows.Forms.TabPage();
            this.pnlFull = new System.Windows.Forms.Panel();
            this.btnDESEncryptOrDecrypt = new System.Windows.Forms.Button();
            this.txtDESTargetText = new System.Windows.Forms.TextBox();
            this.lblDESTargetText = new System.Windows.Forms.Label();
            this.lblDESSourceText = new System.Windows.Forms.Label();
            this.txtDESSourceText = new System.Windows.Forms.TextBox();
            this.btnRSAEncryptOrDecrypt = new System.Windows.Forms.Button();
            this.txtRSATargetText = new System.Windows.Forms.TextBox();
            this.lblRSATargetText = new System.Windows.Forms.Label();
            this.lblRSASourceText = new System.Windows.Forms.Label();
            this.txtRSASourceText = new System.Windows.Forms.TextBox();
            this.rdbRSADecrypt = new System.Windows.Forms.RadioButton();
            this.rdbRSAEncrypt = new System.Windows.Forms.RadioButton();
            this.txtRSAKey = new System.Windows.Forms.TextBox();
            this.lblRSAKey = new System.Windows.Forms.Label();
            this.txtDESKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDESKeyRemark = new System.Windows.Forms.Label();
            this.btnCreateKeys = new System.Windows.Forms.Button();
            this.tabEncodeType.SuspendLayout();
            this.tbpMD5.SuspendLayout();
            this.tbpDES.SuspendLayout();
            this.tbpRSA.SuspendLayout();
            this.pnlFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEncodeType
            // 
            this.tabEncodeType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEncodeType.Controls.Add(this.tbpMD5);
            this.tabEncodeType.Controls.Add(this.tbpDES);
            this.tabEncodeType.Controls.Add(this.tbpRSA);
            this.tabEncodeType.Location = new System.Drawing.Point(3, 3);
            this.tabEncodeType.Name = "tabEncodeType";
            this.tabEncodeType.SelectedIndex = 0;
            this.tabEncodeType.Size = new System.Drawing.Size(478, 324);
            this.tabEncodeType.TabIndex = 0;
            // 
            // tbpMD5
            // 
            this.tbpMD5.Controls.Add(this.btnMD5Encrypt);
            this.tbpMD5.Controls.Add(this.txtMD5Ciphertext);
            this.tbpMD5.Controls.Add(this.lblCiphertext);
            this.tbpMD5.Controls.Add(this.lblSourceText);
            this.tbpMD5.Controls.Add(this.txtMD5SourceText);
            this.tbpMD5.Location = new System.Drawing.Point(4, 22);
            this.tbpMD5.Name = "tbpMD5";
            this.tbpMD5.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMD5.Size = new System.Drawing.Size(470, 298);
            this.tbpMD5.TabIndex = 0;
            this.tbpMD5.Text = "MD5 加密";
            this.tbpMD5.UseVisualStyleBackColor = true;
            // 
            // btnMD5Encrypt
            // 
            this.btnMD5Encrypt.Location = new System.Drawing.Point(72, 112);
            this.btnMD5Encrypt.Name = "btnMD5Encrypt";
            this.btnMD5Encrypt.Size = new System.Drawing.Size(75, 25);
            this.btnMD5Encrypt.TabIndex = 4;
            this.btnMD5Encrypt.Text = "加密";
            this.btnMD5Encrypt.UseVisualStyleBackColor = true;
            this.btnMD5Encrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtMD5Ciphertext
            // 
            this.txtMD5Ciphertext.Location = new System.Drawing.Point(72, 143);
            this.txtMD5Ciphertext.Multiline = true;
            this.txtMD5Ciphertext.Name = "txtMD5Ciphertext";
            this.txtMD5Ciphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMD5Ciphertext.Size = new System.Drawing.Size(392, 100);
            this.txtMD5Ciphertext.TabIndex = 3;
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.Location = new System.Drawing.Point(6, 146);
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.Size = new System.Drawing.Size(60, 12);
            this.lblCiphertext.TabIndex = 2;
            this.lblCiphertext.Text = "目标文本";
            this.lblCiphertext.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSourceText
            // 
            this.lblSourceText.Location = new System.Drawing.Point(6, 9);
            this.lblSourceText.Name = "lblSourceText";
            this.lblSourceText.Size = new System.Drawing.Size(60, 12);
            this.lblSourceText.TabIndex = 1;
            this.lblSourceText.Text = "源文本";
            this.lblSourceText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMD5SourceText
            // 
            this.txtMD5SourceText.Location = new System.Drawing.Point(72, 6);
            this.txtMD5SourceText.Multiline = true;
            this.txtMD5SourceText.Name = "txtMD5SourceText";
            this.txtMD5SourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMD5SourceText.Size = new System.Drawing.Size(393, 100);
            this.txtMD5SourceText.TabIndex = 0;
            // 
            // tbpDES
            // 
            this.tbpDES.Controls.Add(this.lblDESKeyRemark);
            this.tbpDES.Controls.Add(this.label1);
            this.tbpDES.Controls.Add(this.txtDESKey);
            this.tbpDES.Controls.Add(this.btnDESEncryptOrDecrypt);
            this.tbpDES.Controls.Add(this.txtDESTargetText);
            this.tbpDES.Controls.Add(this.lblDESTargetText);
            this.tbpDES.Controls.Add(this.lblDESSourceText);
            this.tbpDES.Controls.Add(this.txtDESSourceText);
            this.tbpDES.Controls.Add(this.rdbDESDecrypt);
            this.tbpDES.Controls.Add(this.rdbDESEncrypt);
            this.tbpDES.Location = new System.Drawing.Point(4, 22);
            this.tbpDES.Name = "tbpDES";
            this.tbpDES.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDES.Size = new System.Drawing.Size(470, 298);
            this.tbpDES.TabIndex = 1;
            this.tbpDES.Text = "DES 加密 & 解密";
            this.tbpDES.UseVisualStyleBackColor = true;
            // 
            // rdbDESDecrypt
            // 
            this.rdbDESDecrypt.AutoSize = true;
            this.rdbDESDecrypt.Location = new System.Drawing.Point(59, 6);
            this.rdbDESDecrypt.Name = "rdbDESDecrypt";
            this.rdbDESDecrypt.Size = new System.Drawing.Size(47, 16);
            this.rdbDESDecrypt.TabIndex = 1;
            this.rdbDESDecrypt.TabStop = true;
            this.rdbDESDecrypt.Text = "解密";
            this.rdbDESDecrypt.UseVisualStyleBackColor = true;
            this.rdbDESDecrypt.CheckedChanged += new System.EventHandler(this.rdbDESDecrypt_CheckedChanged);
            // 
            // rdbDESEncrypt
            // 
            this.rdbDESEncrypt.AutoSize = true;
            this.rdbDESEncrypt.Checked = true;
            this.rdbDESEncrypt.Location = new System.Drawing.Point(6, 6);
            this.rdbDESEncrypt.Name = "rdbDESEncrypt";
            this.rdbDESEncrypt.Size = new System.Drawing.Size(47, 16);
            this.rdbDESEncrypt.TabIndex = 0;
            this.rdbDESEncrypt.TabStop = true;
            this.rdbDESEncrypt.Text = "加密";
            this.rdbDESEncrypt.UseVisualStyleBackColor = true;
            this.rdbDESEncrypt.CheckedChanged += new System.EventHandler(this.rdbDESEncrypt_CheckedChanged);
            // 
            // tbpRSA
            // 
            this.tbpRSA.Controls.Add(this.btnCreateKeys);
            this.tbpRSA.Controls.Add(this.lblRSAKey);
            this.tbpRSA.Controls.Add(this.txtRSAKey);
            this.tbpRSA.Controls.Add(this.btnRSAEncryptOrDecrypt);
            this.tbpRSA.Controls.Add(this.txtRSATargetText);
            this.tbpRSA.Controls.Add(this.lblRSATargetText);
            this.tbpRSA.Controls.Add(this.lblRSASourceText);
            this.tbpRSA.Controls.Add(this.txtRSASourceText);
            this.tbpRSA.Controls.Add(this.rdbRSADecrypt);
            this.tbpRSA.Controls.Add(this.rdbRSAEncrypt);
            this.tbpRSA.Location = new System.Drawing.Point(4, 22);
            this.tbpRSA.Name = "tbpRSA";
            this.tbpRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRSA.Size = new System.Drawing.Size(470, 298);
            this.tbpRSA.TabIndex = 2;
            this.tbpRSA.Text = "RSA 加密 & 解密";
            this.tbpRSA.UseVisualStyleBackColor = true;
            // 
            // pnlFull
            // 
            this.pnlFull.Controls.Add(this.tabEncodeType);
            this.pnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFull.Location = new System.Drawing.Point(0, 0);
            this.pnlFull.Name = "pnlFull";
            this.pnlFull.Size = new System.Drawing.Size(484, 330);
            this.pnlFull.TabIndex = 1;
            // 
            // btnDESEncryptOrDecrypt
            // 
            this.btnDESEncryptOrDecrypt.Location = new System.Drawing.Point(72, 161);
            this.btnDESEncryptOrDecrypt.Name = "btnDESEncryptOrDecrypt";
            this.btnDESEncryptOrDecrypt.Size = new System.Drawing.Size(75, 25);
            this.btnDESEncryptOrDecrypt.TabIndex = 9;
            this.btnDESEncryptOrDecrypt.Text = "加密";
            this.btnDESEncryptOrDecrypt.UseVisualStyleBackColor = true;
            this.btnDESEncryptOrDecrypt.Click += new System.EventHandler(this.btnDESEncryptOrDecrypt_Click);
            // 
            // txtDESTargetText
            // 
            this.txtDESTargetText.Location = new System.Drawing.Point(72, 192);
            this.txtDESTargetText.Multiline = true;
            this.txtDESTargetText.Name = "txtDESTargetText";
            this.txtDESTargetText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDESTargetText.Size = new System.Drawing.Size(392, 100);
            this.txtDESTargetText.TabIndex = 8;
            // 
            // lblDESTargetText
            // 
            this.lblDESTargetText.Location = new System.Drawing.Point(6, 195);
            this.lblDESTargetText.Name = "lblDESTargetText";
            this.lblDESTargetText.Size = new System.Drawing.Size(60, 12);
            this.lblDESTargetText.TabIndex = 7;
            this.lblDESTargetText.Text = "目标文本";
            this.lblDESTargetText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDESSourceText
            // 
            this.lblDESSourceText.Location = new System.Drawing.Point(6, 31);
            this.lblDESSourceText.Name = "lblDESSourceText";
            this.lblDESSourceText.Size = new System.Drawing.Size(60, 12);
            this.lblDESSourceText.TabIndex = 6;
            this.lblDESSourceText.Text = "源文本";
            this.lblDESSourceText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDESSourceText
            // 
            this.txtDESSourceText.Location = new System.Drawing.Point(72, 28);
            this.txtDESSourceText.Multiline = true;
            this.txtDESSourceText.Name = "txtDESSourceText";
            this.txtDESSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDESSourceText.Size = new System.Drawing.Size(392, 100);
            this.txtDESSourceText.TabIndex = 5;
            // 
            // btnRSAEncryptOrDecrypt
            // 
            this.btnRSAEncryptOrDecrypt.Location = new System.Drawing.Point(72, 161);
            this.btnRSAEncryptOrDecrypt.Name = "btnRSAEncryptOrDecrypt";
            this.btnRSAEncryptOrDecrypt.Size = new System.Drawing.Size(75, 25);
            this.btnRSAEncryptOrDecrypt.TabIndex = 16;
            this.btnRSAEncryptOrDecrypt.Text = "加密";
            this.btnRSAEncryptOrDecrypt.UseVisualStyleBackColor = true;
            this.btnRSAEncryptOrDecrypt.Click += new System.EventHandler(this.btnRSAEncryptOrDecrypt_Click);
            // 
            // txtRSATargetText
            // 
            this.txtRSATargetText.Location = new System.Drawing.Point(72, 192);
            this.txtRSATargetText.Multiline = true;
            this.txtRSATargetText.Name = "txtRSATargetText";
            this.txtRSATargetText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSATargetText.Size = new System.Drawing.Size(392, 100);
            this.txtRSATargetText.TabIndex = 15;
            // 
            // lblRSATargetText
            // 
            this.lblRSATargetText.Location = new System.Drawing.Point(6, 195);
            this.lblRSATargetText.Name = "lblRSATargetText";
            this.lblRSATargetText.Size = new System.Drawing.Size(60, 12);
            this.lblRSATargetText.TabIndex = 14;
            this.lblRSATargetText.Text = "目标文本";
            this.lblRSATargetText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRSASourceText
            // 
            this.lblRSASourceText.Location = new System.Drawing.Point(6, 31);
            this.lblRSASourceText.Name = "lblRSASourceText";
            this.lblRSASourceText.Size = new System.Drawing.Size(60, 12);
            this.lblRSASourceText.TabIndex = 13;
            this.lblRSASourceText.Text = "源文本";
            this.lblRSASourceText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRSASourceText
            // 
            this.txtRSASourceText.Location = new System.Drawing.Point(72, 28);
            this.txtRSASourceText.Multiline = true;
            this.txtRSASourceText.Name = "txtRSASourceText";
            this.txtRSASourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSASourceText.Size = new System.Drawing.Size(392, 100);
            this.txtRSASourceText.TabIndex = 12;
            // 
            // rdbRSADecrypt
            // 
            this.rdbRSADecrypt.AutoSize = true;
            this.rdbRSADecrypt.Location = new System.Drawing.Point(59, 6);
            this.rdbRSADecrypt.Name = "rdbRSADecrypt";
            this.rdbRSADecrypt.Size = new System.Drawing.Size(47, 16);
            this.rdbRSADecrypt.TabIndex = 11;
            this.rdbRSADecrypt.TabStop = true;
            this.rdbRSADecrypt.Text = "解密";
            this.rdbRSADecrypt.UseVisualStyleBackColor = true;
            this.rdbRSADecrypt.CheckedChanged += new System.EventHandler(this.rdbRSADecrypt_CheckedChanged);
            // 
            // rdbRSAEncrypt
            // 
            this.rdbRSAEncrypt.AutoSize = true;
            this.rdbRSAEncrypt.Checked = true;
            this.rdbRSAEncrypt.Location = new System.Drawing.Point(6, 6);
            this.rdbRSAEncrypt.Name = "rdbRSAEncrypt";
            this.rdbRSAEncrypt.Size = new System.Drawing.Size(47, 16);
            this.rdbRSAEncrypt.TabIndex = 10;
            this.rdbRSAEncrypt.TabStop = true;
            this.rdbRSAEncrypt.Text = "加密";
            this.rdbRSAEncrypt.UseVisualStyleBackColor = true;
            this.rdbRSAEncrypt.CheckedChanged += new System.EventHandler(this.rdbRSAEncrypt_CheckedChanged);
            // 
            // txtRSAKey
            // 
            this.txtRSAKey.Location = new System.Drawing.Point(72, 134);
            this.txtRSAKey.Name = "txtRSAKey";
            this.txtRSAKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSAKey.Size = new System.Drawing.Size(392, 21);
            this.txtRSAKey.TabIndex = 17;
            // 
            // lblRSAKey
            // 
            this.lblRSAKey.Location = new System.Drawing.Point(6, 137);
            this.lblRSAKey.Name = "lblRSAKey";
            this.lblRSAKey.Size = new System.Drawing.Size(60, 12);
            this.lblRSAKey.TabIndex = 18;
            this.lblRSAKey.Text = "密钥";
            this.lblRSAKey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDESKey
            // 
            this.txtDESKey.Location = new System.Drawing.Point(72, 134);
            this.txtDESKey.MaxLength = 8;
            this.txtDESKey.Name = "txtDESKey";
            this.txtDESKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDESKey.Size = new System.Drawing.Size(120, 21);
            this.txtDESKey.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "密钥";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDESKeyRemark
            // 
            this.lblDESKeyRemark.ForeColor = System.Drawing.Color.Red;
            this.lblDESKeyRemark.Location = new System.Drawing.Point(198, 137);
            this.lblDESKeyRemark.Name = "lblDESKeyRemark";
            this.lblDESKeyRemark.Size = new System.Drawing.Size(100, 12);
            this.lblDESKeyRemark.TabIndex = 12;
            this.lblDESKeyRemark.Text = "（8位半角字符）";
            // 
            // btnCreateKeys
            // 
            this.btnCreateKeys.Location = new System.Drawing.Point(364, 161);
            this.btnCreateKeys.Name = "btnCreateKeys";
            this.btnCreateKeys.Size = new System.Drawing.Size(100, 25);
            this.btnCreateKeys.TabIndex = 19;
            this.btnCreateKeys.Text = "生成RSA密钥";
            this.btnCreateKeys.UseVisualStyleBackColor = true;
            this.btnCreateKeys.Click += new System.EventHandler(this.btnCreateKeys_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.pnlFull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密&解密";
            this.tabEncodeType.ResumeLayout(false);
            this.tbpMD5.ResumeLayout(false);
            this.tbpMD5.PerformLayout();
            this.tbpDES.ResumeLayout(false);
            this.tbpDES.PerformLayout();
            this.tbpRSA.ResumeLayout(false);
            this.tbpRSA.PerformLayout();
            this.pnlFull.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEncodeType;
        private System.Windows.Forms.TabPage tbpMD5;
        private System.Windows.Forms.TabPage tbpDES;
        private System.Windows.Forms.Panel pnlFull;
        private System.Windows.Forms.TabPage tbpRSA;
        private System.Windows.Forms.TextBox txtMD5SourceText;
        private System.Windows.Forms.Label lblSourceText;
        private System.Windows.Forms.Label lblCiphertext;
        private System.Windows.Forms.TextBox txtMD5Ciphertext;
        private System.Windows.Forms.Button btnMD5Encrypt;
        private System.Windows.Forms.RadioButton rdbDESEncrypt;
        private System.Windows.Forms.RadioButton rdbDESDecrypt;
        private System.Windows.Forms.Button btnDESEncryptOrDecrypt;
        private System.Windows.Forms.TextBox txtDESTargetText;
        private System.Windows.Forms.Label lblDESTargetText;
        private System.Windows.Forms.Label lblDESSourceText;
        private System.Windows.Forms.TextBox txtDESSourceText;
        private System.Windows.Forms.TextBox txtRSAKey;
        private System.Windows.Forms.Button btnRSAEncryptOrDecrypt;
        private System.Windows.Forms.TextBox txtRSATargetText;
        private System.Windows.Forms.Label lblRSATargetText;
        private System.Windows.Forms.Label lblRSASourceText;
        private System.Windows.Forms.TextBox txtRSASourceText;
        private System.Windows.Forms.RadioButton rdbRSADecrypt;
        private System.Windows.Forms.RadioButton rdbRSAEncrypt;
        private System.Windows.Forms.Label lblRSAKey;
        private System.Windows.Forms.TextBox txtDESKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDESKeyRemark;
        private System.Windows.Forms.Button btnCreateKeys;
    }
}