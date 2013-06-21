using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rdbDESDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            this.btnDESEncryptOrDecrypt.Text = this.rdbDESDecrypt.Text;
        }

        private void rdbDESEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            this.btnDESEncryptOrDecrypt.Text = this.rdbDESEncrypt.Text;
        }

        private void rdbRSADecrypt_CheckedChanged(object sender, EventArgs e)
        {
            this.btnRSAEncryptOrDecrypt.Text = this.rdbRSADecrypt.Text;
        }

        private void rdbRSAEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            this.btnRSAEncryptOrDecrypt.Text = this.rdbRSAEncrypt.Text;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string sourceText = string.Empty;//明文
            string ciphertext = string.Empty;//密文

            sourceText = this.txtMD5SourceText.Text;//获取明文
            ciphertext = Encoder.MD5Encrypt(sourceText);//加密并获得密文

            this.txtMD5Ciphertext.Text = ciphertext;
        }

        private void btnDESEncryptOrDecrypt_Click(object sender, EventArgs e)
        {
            /*
             * DES 加密 & 解密
             */
            string sourceText = this.txtDESSourceText.Text;
            string key = this.txtDESKey.Text;

            if (string.IsNullOrEmpty(sourceText))
            {
                MessageBox.Show("源文本不能为空。");
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("密钥不能为空。");
                return;
            }

            string targetText = string.Empty;

            if (this.rdbDESEncrypt.Checked)
            {
                /* DES 加密 */
                try
                {
                    targetText = Encoder.DESEncrypt(sourceText, key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加密失败！\r\nError:" + ex.Message);
                }
            }
            else
            {
                /* DES 解密 */
                try
                {
                    targetText = Encoder.DESDecrypt(sourceText, key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("解密失败！\r\nError:" + ex.Message);
                }
            }

            this.txtDESTargetText.Text = targetText;
        }

        private void btnRSAEncryptOrDecrypt_Click(object sender, EventArgs e)
        {
            /*
             * RSA 加密 & 解密
             */
            string sourceText = this.txtRSASourceText.Text;
            string key = this.txtRSAKey.Text;

            if (string.IsNullOrEmpty(sourceText))
            {
                MessageBox.Show("源文本不能为空。");
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("密钥不能为空。");
                return;
            }

            string targetText = string.Empty;

            if (this.rdbRSAEncrypt.Checked)
            {
                /* RSA 加密 */
                try
                {
                    targetText = Encoder.RSAEncrypt(sourceText, key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("解密失败！\r\nError:" + ex.Message);
                }
            }
            else
            {
                /* RSA 解密 */
                try
                {
                    targetText = Encoder.RSADecrypt(sourceText, key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("解密失败！\r\nError:" + ex.Message);
                }
            }

            this.txtRSATargetText.Text = targetText;
        }

        private void btnCreateKeys_Click(object sender, EventArgs e)
        {
            CreateRSAKeysForm f = new CreateRSAKeysForm();
            f.ShowDialog();
        }
    
    }
}
