namespace serial
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialSetPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageSetPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.dataShowPanel = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.pidname2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pidname1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.sendPanel = new System.Windows.Forms.Panel();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.recPanel = new System.Windows.Forms.Panel();
            this.recTextBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialSetPanel.SuspendLayout();
            this.imageSetPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.commandPanel.SuspendLayout();
            this.sendPanel.SuspendLayout();
            this.recPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialSetPanel
            // 
            this.serialSetPanel.Controls.Add(this.button1);
            this.serialSetPanel.Controls.Add(this.comboBox2);
            this.serialSetPanel.Controls.Add(this.label2);
            this.serialSetPanel.Controls.Add(this.comboBox1);
            this.serialSetPanel.Controls.Add(this.label1);
            this.serialSetPanel.Location = new System.Drawing.Point(0, 389);
            this.serialSetPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serialSetPanel.Name = "serialSetPanel";
            this.serialSetPanel.Size = new System.Drawing.Size(282, 65);
            this.serialSetPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "115200",
            "57600",
            "9600",
            "4800"});
            this.comboBox2.Location = new System.Drawing.Point(117, 35);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 20);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Tag = "115200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(113, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // imageSetPanel
            // 
            this.imageSetPanel.Controls.Add(this.button6);
            this.imageSetPanel.Location = new System.Drawing.Point(286, 389);
            this.imageSetPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageSetPanel.Name = "imageSetPanel";
            this.imageSetPanel.Size = new System.Drawing.Size(207, 65);
            this.imageSetPanel.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 10);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "保存图像";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // dataShowPanel
            // 
            this.dataShowPanel.Location = new System.Drawing.Point(498, 389);
            this.dataShowPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataShowPanel.Name = "dataShowPanel";
            this.dataShowPanel.Size = new System.Drawing.Size(66, 65);
            this.dataShowPanel.TabIndex = 2;
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.pictureBox1);
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(564, 384);
            this.imagePanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // commandPanel
            // 
            this.commandPanel.Controls.Add(this.pidname2);
            this.commandPanel.Controls.Add(this.button4);
            this.commandPanel.Controls.Add(this.button5);
            this.commandPanel.Controls.Add(this.button3);
            this.commandPanel.Controls.Add(this.comboBox4);
            this.commandPanel.Controls.Add(this.pidname1);
            this.commandPanel.Controls.Add(this.button2);
            this.commandPanel.Controls.Add(this.start);
            this.commandPanel.Location = new System.Drawing.Point(568, 211);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(273, 199);
            this.commandPanel.TabIndex = 4;
            // 
            // pidname2
            // 
            this.pidname2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pidname2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pidname2.FormattingEnabled = true;
            this.pidname2.Items.AddRange(new object[] {
            "直道",
            "弯道",
            "急转"});
            this.pidname2.Location = new System.Drawing.Point(94, 148);
            this.pidname2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pidname2.Name = "pidname2";
            this.pidname2.Size = new System.Drawing.Size(80, 29);
            this.pidname2.TabIndex = 10;
            this.pidname2.Tag = "";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(10, 81);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "查看PID";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(178, 148);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "ok";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(94, 114);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "灰度",
            "二值化",
            "搜线"});
            this.comboBox4.Location = new System.Drawing.Point(10, 114);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 29);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.Tag = "";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // pidname1
            // 
            this.pidname1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pidname1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pidname1.FormattingEnabled = true;
            this.pidname1.Items.AddRange(new object[] {
            "舵机P",
            "舵机D",
            "电机P",
            "电机I",
            "电机D"});
            this.pidname1.Location = new System.Drawing.Point(10, 147);
            this.pidname1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pidname1.Name = "pidname1";
            this.pidname1.Size = new System.Drawing.Size(80, 29);
            this.pidname1.TabIndex = 4;
            this.pidname1.Tag = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(10, 47);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(10, 14);
            this.start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(78, 29);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // sendPanel
            // 
            this.sendPanel.Controls.Add(this.sendTextBox);
            this.sendPanel.Location = new System.Drawing.Point(568, 412);
            this.sendPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendPanel.Name = "sendPanel";
            this.sendPanel.Size = new System.Drawing.Size(273, 42);
            this.sendPanel.TabIndex = 5;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTextBox.Location = new System.Drawing.Point(2, 3);
            this.sendTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(270, 32);
            this.sendTextBox.TabIndex = 0;
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // recPanel
            // 
            this.recPanel.Controls.Add(this.recTextBox);
            this.recPanel.Location = new System.Drawing.Point(568, 0);
            this.recPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recPanel.Name = "recPanel";
            this.recPanel.Size = new System.Drawing.Size(273, 206);
            this.recPanel.TabIndex = 6;
            // 
            // recTextBox
            // 
            this.recTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recTextBox.Location = new System.Drawing.Point(2, 2);
            this.recTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recTextBox.Multiline = true;
            this.recTextBox.Name = "recTextBox";
            this.recTextBox.Size = new System.Drawing.Size(272, 202);
            this.recTextBox.TabIndex = 0;
            this.recTextBox.TextChanged += new System.EventHandler(this.recTextBox_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceive);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 452);
            this.Controls.Add(this.imageSetPanel);
            this.Controls.Add(this.recPanel);
            this.Controls.Add(this.dataShowPanel);
            this.Controls.Add(this.sendPanel);
            this.Controls.Add(this.commandPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.serialSetPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.serialSetPanel.ResumeLayout(false);
            this.serialSetPanel.PerformLayout();
            this.imageSetPanel.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.commandPanel.ResumeLayout(false);
            this.sendPanel.ResumeLayout(false);
            this.sendPanel.PerformLayout();
            this.recPanel.ResumeLayout(false);
            this.recPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel serialSetPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel imageSetPanel;
        private System.Windows.Forms.Panel dataShowPanel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.Panel sendPanel;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Panel recPanel;
        private System.Windows.Forms.TextBox recTextBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox pidname1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox pidname2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
    }
}

