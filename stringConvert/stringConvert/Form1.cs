using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stringConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private string string2unicode(string intext)
        {
            //汉字转为Unicode编码：
            byte[] b = Encoding.Unicode.GetBytes(intext);
            string outtext = "";
            foreach (var x in b)
            {
                outtext += string.Format("{0:X2}", x) + " ";
            }
            return outtext;
        }

        private string unicode2string(string intext)
        {
            //Unicode编码转为汉字：
            string cd = intext;
            string cd2 = cd.Replace(" ", "");
            cd2 = cd2.Replace("\r", "");
            cd2 = cd2.Replace("\n", "");
            cd2 = cd2.Replace("\r\n", "");
            cd2 = cd2.Replace("\t", "");
            if (cd2.Length % 4 != 0)
            {
                MessageBox.Show("Unicode编码为双字节，请删多或补少！确保是二的倍数。");
                return "";
            }
            else
            {
                int len = cd2.Length / 2;
                byte[] b = new byte[len];
                for (int i = 0; i < cd2.Length; i += 2)
                {
                    string bi = cd2.Substring(i, 2);
                    b[i / 2] = (byte)Convert.ToInt32(bi, 16);
                }
                string outtext = Encoding.Unicode.GetString(b);
                return outtext;
            }
        }

        private string string2gbk(string intext)
        {
            //汉字转成GBK十六进制码：
            string hz = intext.ToString();
            byte[] gbk = Encoding.GetEncoding("GBK").GetBytes(hz);
            string s1 = ""; string s1d = "";
            foreach (byte b in gbk)
            {
                //s1 += Convert.ToString(b, 16)+" ";
                s1 += string.Format("{0:X2}", b) + " ";
                s1d += b + " ";
            }
            return s1;

        }

        private string gbk2string(string intext)
        {
            //GBK十六进制码转成汉字：
            string cd = intext;
            string[] b4 = cd.Split(' ');
            byte[] bs = new byte[2];
            bs[0] = (byte)Convert.ToByte(b4[0], 16);
            bs[1] = (byte)Convert.ToByte(b4[1], 16);
            return Encoding.GetEncoding("GBK").GetString(bs);
 
        }



        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox_des.Text = string2unicode(textBox_souce.Text);
                    break;
                case 1:
                    textBox_des.Text = unicode2string(textBox_souce.Text);
                    break;
                default:
                    break;
            }
        }


    }
}
