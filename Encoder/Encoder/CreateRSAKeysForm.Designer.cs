namespace Encoder
{
    partial class CreateRSAKeysForm
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
            this.txtPublishKey = new System.Windows.Forms.TextBox();
            this.pnlFull = new System.Windows.Forms.Panel();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPublishKey = new System.Windows.Forms.Label();
            this.pnlFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPublishKey
            // 
            this.txtPublishKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublishKey.Location = new System.Drawing.Point(47, 3);
            this.txtPublishKey.Multiline = true;
            this.txtPublishKey.Name = "txtPublishKey";
            this.txtPublishKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublishKey.Size = new System.Drawing.Size(334, 100);
            this.txtPublishKey.TabIndex = 13;
            // 
            // pnlFull
            // 
            this.pnlFull.Controls.Add(this.txtPrivateKey);
            this.pnlFull.Controls.Add(this.label1);
            this.pnlFull.Controls.Add(this.lblPublishKey);
            this.pnlFull.Controls.Add(this.txtPublishKey);
            this.pnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFull.Location = new System.Drawing.Point(0, 0);
            this.pnlFull.Name = "pnlFull";
            this.pnlFull.Size = new System.Drawing.Size(384, 212);
            this.pnlFull.TabIndex = 14;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivateKey.Location = new System.Drawing.Point(47, 109);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivateKey.Size = new System.Drawing.Size(334, 100);
            this.txtPrivateKey.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "私钥";
            // 
            // lblPublishKey
            // 
            this.lblPublishKey.AutoSize = true;
            this.lblPublishKey.Location = new System.Drawing.Point(12, 9);
            this.lblPublishKey.Name = "lblPublishKey";
            this.lblPublishKey.Size = new System.Drawing.Size(29, 12);
            this.lblPublishKey.TabIndex = 14;
            this.lblPublishKey.Text = "公钥";
            // 
            // CreateRSAKeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.pnlFull);
            this.Name = "CreateRSAKeysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RSA 密钥";
            this.Load += new System.EventHandler(this.CreateRSAKeysForm_Load);
            this.pnlFull.ResumeLayout(false);
            this.pnlFull.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPublishKey;
        private System.Windows.Forms.Panel pnlFull;
        private System.Windows.Forms.Label lblPublishKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrivateKey;
    }
}