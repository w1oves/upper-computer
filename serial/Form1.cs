using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace serial
{
    public partial class Form1 : Form
    {
        public const byte START = 1;
        public const byte STOP = 2;
        public const byte SENDGRAY = 3;
        public const byte SHOW_PID = 4;
        public const byte SET_PID_MOTOR_P = 5;
        public const byte SET_PID_MOTOR_I = 6;
        public const byte SET_PID_MOTOR_D = 7;
        public const byte SET_PID_SERVO_STRAIGHT_P = 8;
        public const byte SET_PID_SERVO_STRAIGHT_D = 9;
        public const byte SET_PID_SERVO_TURN_P = 10;
        public const byte SET_PID_SERVO_TURN_D = 11;
        public const byte SET_PID_SERVO_BIG_TURN_P = 12;
        public const byte SET_PID_SERVO_BIG_TURN_D = 13;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string subPath = "D://photo";
            if (false == System.IO.Directory.Exists(subPath))
            {
                //创建pic文件夹
                System.IO.Directory.CreateDirectory(subPath);
            }
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            pidname1.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            pidname2.SelectedIndex = 0;
            serialPort1.ReadBufferSize = 188 * 120 + 10;
            isimage = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //将可能产生异常的代码放置在try块中
                //根据当前串口属性来判断是否打开
                if (serialPort1.IsOpen)
                {
                    //串口已经处于打开状态
                    serialPort1.Close();    //关闭串口
                    button1.Text = "打开串口";
                    button1.BackColor = Color.ForestGreen;
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    serialPort1.Open();     //打开串口
                    button1.Text = "关闭串口";
                    button1.BackColor = Color.Firebrick;
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理

                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                button1.Text = "打开串口";
                button1.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
        }


        private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    //首先判断串口是否开启
                    if (serialPort1.IsOpen)
                    {
                        //串口处于开启状态，将发送区文本发送
                        float s = Convert.ToSingle(sendTextBox.Text.ToString());
                        uint front = Convert.ToUInt16(s);
                        uint rear = Convert.ToUInt16(s * 100 - front * 100);
                        byte t = Convert.ToByte(front);
                        temp[0] = t;
                        serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                        t = Convert.ToByte(rear);
                        temp[0] = t;
                        serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                        
                        recTextBox.AppendText(sendTextBox.Text + ";\r\n");
                    }
                }
                catch (Exception ex)
                {
                    //捕获到异常，创建一个新的对象，之前的不可以再用
                    serialPort1 = new System.IO.Ports.SerialPort();
                    //刷新COM口选项
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                    //响铃并显示异常给用户
                    System.Media.SystemSounds.Beep.Play();
                    button1.Text = "打开串口";
                    button1.BackColor = Color.ForestGreen;
                    MessageBox.Show(ex.Message);
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                }
            }
        }

        private int isimage;
        // Bitmap bmp;
        private byte[] imagebuff = new byte[188 * 120];
        private int imageRecNum = 0;
        private int getImage = 0;


        private void Analyze(byte[] buf, StringBuilder sb)
        {
            int offset = 0;
            if (isimage == 0)
            {
                if (buf.Length < 4)
                {
                    offset += buf.Length;
                    sb.Append(Encoding.ASCII.GetString(buf));
                }
                else
                {
                    byte[] four = new byte[4];
                    Array.Copy(buf, offset, four, 0, 4);
                    offset += 4;
                    if (four[0] == 0x00 && four[1] == 0xff && four[2] == 0x01 && four[3] == 0x01)
                        isimage = 1;
                    else
                    {
                        sb.Append(Encoding.ASCII.GetString(four));
                    }
                }
            }
            if (isimage == 1)
            {
                int count = buf.Length - offset;
                if (count + imageRecNum > 188 * 120)
                    count = 188 * 120 - imageRecNum;
                Array.Copy(buf, offset, imagebuff, imageRecNum, count);
                offset += count;
                imageRecNum += count;
                if (imageRecNum >= 188 * 120)
                {
                    getImage = 1;
                    isimage = 0;
                }
            }
            byte[] remain = new byte[buf.Length - offset];
            if (remain.Length > 0)
            {
                Array.Copy(buf, offset, remain, 0, remain.Length);
                Analyze(remain, sb);
            }
        }
        StringBuilder sb = new StringBuilder();
        private void SerialPort1_DataReceive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int count = serialPort1.BytesToRead;
            byte[] buff = new byte[count];
            serialPort1.Read(buff, 0, count);
            sb.Clear();
            Analyze(buff, sb);
            recTextBox.AppendText(sb.ToString());
            if (getImage == 1)
            {
                Bitmap bmp = CreateBitmap(imagebuff, 188, 120);
                bmp.Save(@"D:\photo\tmp.bmp");
                pictureBox1.LoadAsync(@"D:\photo\tmp.bmp");
                getImage = 0;
                imageRecNum = 0;
            }
            //因为要访问UI资源，所以需要使用invoke方式同步ui
            //this.Invoke((EventHandler)(delegate
            //{


            //}
            //   )
            //);
        }
        public static Bitmap CreateBitmap(byte[] originalImageData, int originalWidth, int originalHeight)
        {
            //指定8位格式，即256色
            Bitmap resultBitmap = new Bitmap(originalWidth, originalHeight, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

            //将该位图存入内存中
            MemoryStream curImageStream = new MemoryStream();
            resultBitmap.Save(curImageStream, System.Drawing.Imaging.ImageFormat.Bmp);
            curImageStream.Flush();

            //由于位图数据需要DWORD对齐（4byte倍数），计算需要补位的个数
            int curPadNum = ((originalWidth * 8 + 31) / 32 * 4) - originalWidth;

            //最终生成的位图数据大小
            int bitmapDataSize = ((originalWidth * 8 + 31) / 32 * 4) * originalHeight;

            //数据部分相对文件开始偏移，具体可以参考位图文件格式
            int dataOffset = ReadData(curImageStream, 10, 4);


            //改变调色板，因为默认的调色板是32位彩色的，需要修改为256色的调色板
            int paletteStart = 54;
            int paletteEnd = dataOffset;
            int color = 0;

            for (int i = paletteStart; i < paletteEnd; i += 4)
            {
                byte[] tempColor = new byte[4];
                tempColor[0] = (byte)color;
                tempColor[1] = (byte)color;
                tempColor[2] = (byte)color;
                tempColor[3] = (byte)0;
                color++;

                curImageStream.Position = i;
                curImageStream.Write(tempColor, 0, 4);
            }

            //最终生成的位图数据，以及大小，高度没有变，宽度需要调整
            byte[] destImageData = new byte[bitmapDataSize];
            int destWidth = originalWidth + curPadNum;

            //生成最终的位图数据，注意的是，位图数据 从左到右，从下到上，所以需要颠倒
            for (int originalRowIndex = originalHeight - 1; originalRowIndex >= 0; originalRowIndex--)
            {
                int destRowIndex = originalHeight - originalRowIndex - 1;

                for (int dataIndex = 0; dataIndex < originalWidth; dataIndex++)
                {
                    //同时还要注意，新的位图数据的宽度已经变化destWidth，否则会产生错位
                    destImageData[destRowIndex * destWidth + dataIndex] = originalImageData[originalRowIndex * originalWidth + dataIndex];
                }
            }


            //将流的Position移到数据段   
            curImageStream.Position = dataOffset;

            //将新位图数据写入内存中
            curImageStream.Write(destImageData, 0, bitmapDataSize);

            curImageStream.Flush();

            //将内存中的位图写入Bitmap对象
            resultBitmap = new Bitmap(curImageStream);

            return resultBitmap;
        }
        public static int ReadData(MemoryStream curStream, int startPosition, int length)
        {
            int result = -1;

            byte[] tempData = new byte[length];
            curStream.Position = startPosition;
            curStream.Read(tempData, 0, length);
            result = BitConverter.ToInt32(tempData, 0);

            return result;
        }

        /// <summary>
        /// 向内存流中指定位置，写入数据
        /// </summary>
        /// <param name="curStream"></param>
        /// <param name="startPosition"></param>
        /// <param name="length"></param>
        /// <param name="value"></param>
        public static void WriteData(MemoryStream curStream, int startPosition, int length, int value)
        {
            curStream.Position = startPosition;
            curStream.Write(BitConverter.GetBytes(value), 0, length);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private byte[] temp = new byte[1];
        private void start_Click(object sender, EventArgs e)
        {
            recTextBox.Clear();

            if (serialPort1.IsOpen)
            {
                temp[0] = START;
                serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            recTextBox.Clear();
            if (serialPort1.IsOpen)
            {
                temp[0] = STOP;
                serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            recTextBox.Clear();
            if (serialPort1.IsOpen)
            {
                temp[0] = SHOW_PID;
                serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                temp[0] = SENDGRAY;
                serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int duoji = 0;
            recTextBox.Clear();
            if (serialPort1.IsOpen)
                switch (pidname1.SelectedItem.ToString())
                {
                    case "电机P":
                        temp[0] = SET_PID_MOTOR_P;
                        serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                        break;
                    case "电机I":
                        temp[0] = SET_PID_MOTOR_I;
                        serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                        break;
                    case "电机D":
                        temp[0] = SET_PID_MOTOR_D;
                        serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                        break;
                    case "舵机P":
                        duoji = 1;
                        break;
                    case "舵机D":
                        duoji = 2;
                        break;
                    default:
                        break;
                }
            if (duoji != 0)
            {
                if (serialPort1.IsOpen)
                    switch (pidname2.SelectedItem.ToString())
                    {
                        case "直道":
                            if (duoji == 1)
                                temp[0] = SET_PID_SERVO_STRAIGHT_P;
                            else
                                temp[0] = SET_PID_SERVO_STRAIGHT_D;
                            serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                            break;
                        case "弯道":
                            if (duoji == 1)
                                temp[0] = SET_PID_SERVO_TURN_P;
                            else
                                temp[0] = SET_PID_SERVO_TURN_D;
                            serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                            break;
                        case "急转":
                            if (duoji == 1)
                                temp[0] = SET_PID_SERVO_BIG_TURN_P;
                            else
                                temp[0] = SET_PID_SERVO_BIG_TURN_D;
                            serialPort1.Write(System.Text.Encoding.ASCII.GetString(temp));
                            break;
                        default:
                            break;
                    }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            recTextBox.Clear();
        }

        private void recTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            FileStream fss = new FileStream("D://photo/test.txt", FileMode.OpenOrCreate);
            fss.Close();
            StreamReader sr = new StreamReader("D://photo/test.txt", Encoding.Default);
            String line;
            line = sr.ReadLine();
            sr.Close();
            int x = Convert.ToInt16(line);
            x++;
            string filename = @"D://photo/" + x.ToString() + ".bmp";
            FileInfo fl = new FileInfo(@"D://photo/tmp.bmp");
            fl.CopyTo(filename);
            FileStream fs = new FileStream("D://photo/test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(x.ToString());
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
            MessageBox.Show("save OK!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
