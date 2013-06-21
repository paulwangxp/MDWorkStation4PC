namespace MDWorkStation4PC
{
    partial class ShutDownForm
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
            this.button1 = new System.Windows.Forms.ImageButton();
            this.button3 = new System.Windows.Forms.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_AllDay = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SavePath = new System.Windows.Forms.TextBox();
            this.button_SavePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.DownImage = global::MDWorkStation4PC.Properties.Resources.c3;
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.HoverImage = global::MDWorkStation4PC.Properties.Resources.c2;
            this.button1.Location = new System.Drawing.Point(184, 282);
            this.button1.Name = "button1";
            this.button1.NormalImage = global::MDWorkStation4PC.Properties.Resources.c1;
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = "查看数据";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button3.DownImage = global::MDWorkStation4PC.Properties.Resources.c3;
            this.button3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.HoverImage = global::MDWorkStation4PC.Properties.Resources.c2;
            this.button3.Location = new System.Drawing.Point(414, 282);
            this.button3.Name = "button3";
            this.button3.NormalImage = global::MDWorkStation4PC.Properties.Resources.c1;
            this.button3.Size = new System.Drawing.Size(108, 44);
            this.button3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.Text = "关  闭";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "选择上传服务器时间：";
            this.label1.Visible = false;
            // 
            // checkBox_AllDay
            // 
            this.checkBox_AllDay.AutoSize = true;
            this.checkBox_AllDay.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AllDay.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_AllDay.Location = new System.Drawing.Point(307, 65);
            this.checkBox_AllDay.Name = "checkBox_AllDay";
            this.checkBox_AllDay.Size = new System.Drawing.Size(142, 23);
            this.checkBox_AllDay.TabIndex = 15;
            this.checkBox_AllDay.Text = "全天自动上传";
            this.checkBox_AllDay.UseVisualStyleBackColor = false;
            this.checkBox_AllDay.Visible = false;
            this.checkBox_AllDay.CheckedChanged += new System.EventHandler(this.checkBox_AllDay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(70, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "开始时间：";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(72, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "结束时间：";
            this.label3.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(191, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(72, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "保存路径：";
            // 
            // textBox_SavePath
            // 
            this.textBox_SavePath.Location = new System.Drawing.Point(191, 220);
            this.textBox_SavePath.Name = "textBox_SavePath";
            this.textBox_SavePath.Size = new System.Drawing.Size(375, 21);
            this.textBox_SavePath.TabIndex = 23;
            // 
            // button_SavePath
            // 
            this.button_SavePath.Location = new System.Drawing.Point(572, 218);
            this.button_SavePath.Name = "button_SavePath";
            this.button_SavePath.Size = new System.Drawing.Size(61, 24);
            this.button_SavePath.TabIndex = 24;
            this.button_SavePath.Text = "选择目录";
            this.button_SavePath.UseVisualStyleBackColor = true;
            this.button_SavePath.Click += new System.EventHandler(this.button_SavePath_Click);
            // 
            // ShutDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDWorkStation4PC.Properties.Resources._1_376;
            this.ClientSize = new System.Drawing.Size(687, 368);
            this.Controls.Add(this.button_SavePath);
            this.Controls.Add(this.textBox_SavePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_AllDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ShutDownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择对应的功能";
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageButton button1;
        private System.Windows.Forms.ImageButton button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_AllDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SavePath;
        private System.Windows.Forms.Button button_SavePath;
    }
}