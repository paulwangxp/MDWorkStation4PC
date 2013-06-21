using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace MDWorkStation4PC
{
    public partial class ShutDownForm : Form
    {
        INIFile iniObject = new INIFile();

        public ShutDownForm()
        {
            InitializeComponent();
            checkBox_AllDay.Checked = true;
            dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
            textBox_SavePath.ReadOnly = true;
            string path = iniObject.IniReadValue("config", "SavePath", "\\Data");
            if ( path.Equals("\\Data") || path.Length == 0)
            {
                path = System.Environment.CurrentDirectory + "\\Data";                
                iniObject.IniWriteValue("config", "SavePath", path);
            }

            textBox_SavePath.Text = path;

            //button1.Enabled = Button2.Enabled = false;

        }

        //查看数据
        private void button1_Click(object sender, EventArgs e)
        {
            //LogManager.WriteLog("关闭电脑(shutdown)...");
            //Process.Start("shutdown", "-s -t 60");

            if (!Directory.Exists(textBox_SavePath.Text))//如果设定的目录不存在
            {

                LogManager.showErrorMsg("要查看的数据文件夹不存在！");
                return;
            }

            System.Diagnostics.Process.Start("Explorer.exe", textBox_SavePath.Text);


        }

        //重启电脑
        private void Button2_Click(object sender, EventArgs e)
        {
            LogManager.WriteLog("关闭电脑(reset)...");
            Process.Start("shutdown", "-r -t 60");
        }

        //关闭当前form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //全天上传的checkbox事件
        private void checkBox_AllDay_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = dateTimePicker2.Enabled = !checkBox_AllDay.Checked;
        }

        //设定文件保存目录
        private void button_SavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "请选择文件保存路径";
            dlg.ShowNewFolderButton = true;

            dlg.SelectedPath = iniObject.IniReadValue("config", "SavePath", "\\Data");//目录不允许设置保存路径

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox_SavePath.Text = dlg.SelectedPath;
                iniObject.IniWriteValue("config", "SavePath", dlg.SelectedPath);
                Form1.setSavePath(dlg.SelectedPath);//将设定的值传递给主窗体
            }
        }
    }
}
