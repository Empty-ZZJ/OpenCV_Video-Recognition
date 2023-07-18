using OpenCvSharp;
using OpenCvSharp.Dnn;
using OpenCvSharp.Extensions;
using SkinSharp;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using VideoSystem.Codes;
using VideoSystem.Forms;
using Point = OpenCvSharp.Point;

namespace VideoSystem
{
    public partial class MainForm : Form
    {
        public Full Form_Full = new Full();
        /// <summary>
        /// 当前模式是否为摄像机模式
        /// </summary>
        public bool bl_Camera;
        /// <summary>
        /// 要读取的图片地址
        /// </summary>
        public string PhotoPath = null;
        public VideoCapture capture;
        public SkinH_Net WindowsCoreSkin;
        const int width = 300;
        const int height = 300;
        const float meanVal = 127.5f;
        const float scaleFactor = 0.007843f;
        public int index_cmarea;
        /// <summary>
        /// 支持的识别的物体
        /// </summary>
        string[] classNames = new string[] { "background",
"aeroplane", "bicycle", "bird", "boat",
"bottle", "bus", "car", "cat", "chair",
"cow", "diningtable", "dog", "horse",
"motorbike", "person", "pottedplant",
"sheep", "sofa", "train", "tvmonitor" };
        string[] classNames_cn = new string[] { "背景", "飞机", "自行车", "鸟", "船", "瓶子", "公共汽车", "汽车", "猫", "椅子", "牛", "餐桌", "狗", "马", "摩托车", "人", "盆栽植物", "羊", "沙发", "火车", "显示器" };
        public struct Image_Data_GDI
        {
            public string text;
            public PointF P;
        };
        public static Image_Data_GDI _Image_Data_GDI = new Image_Data_GDI();
        /// <summary>
        /// 运行地址
        /// </summary>
        public static string RunPath = System.Windows.Forms.Application.StartupPath;
        public MainForm ()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void MainForm_Load (object sender, EventArgs e)
        {
            _Image_Data_GDI.text = "";
            Skin_class:
            {
                WindowsCoreSkin = new SkinH_Net();
                WindowsCoreSkin.AttachEx(System.Windows.Forms.Application.StartupPath + "\\Public\\windows-core-ui.she", "");
                int mycolor;
                System.Drawing.Color c = System.Drawing.Color.DarkGray;
                mycolor = c.A * 256 * 256 * 256 + c.R * 256 * 256 + c.G * 256 + c.B;
                IntPtr hWnd = DllImport_Pro.DllImport_Pro.FindWindow(null, "物体识别与追踪系统");
                DllImport_Pro.DllImport_Pro.windows_shadow(hWnd.ToInt32(), mycolor, 5);

            }
            var Thread_LoadList = new Thread(LoadList); Thread_LoadList.Start();
            var Thread_CameraList = new Thread(LoadCameraList); Thread_CameraList.Start();
            //DllImport_Pro.DllImport_Pro.SetWindowTheme(LeftView.Handle.ToInt32(), "Explorer".ToCharArray(), 0);
            //DllImport_Pro.DllImport_Pro.SendMessageA(LeftView.Handle.ToInt32(), 4150, 0, 35536 | 32 | 0);

            PictureBoxImage.Image = GetImg.GetImgFrom_File(RunPath + "/image/none.png");
        }
        private void 打开ToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (bl_Camera)
            {
                MessageBox.Show("已经打开摄像机", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            //该值确定是否可以选择多个文件
            dialog.Multiselect = false;
            dialog.Title = "请选择要识别的图片";
            dialog.Filter = "所有文件|*.*|png文件|*.png|jpg文件|*.jpg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PhotoPath = null;
                PhotoPath = dialog.FileName;
                if (!File.Exists(PhotoPath))
                {
                    MessageBox.Show("当前文件不存在，请重新选择！", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PictureBoxImage.Image = Thread_LoadPhoto(Cv2.ImRead(PhotoPath, ImreadModes.Color));

            }

        }
        /// <summary>
        /// 处理1张图片，返回可可以在image上显示的Bitmap类型
        /// </summary>
        /// <param name="frame"></param>
        /// <returns></returns>
        public System.Drawing.Bitmap Thread_LoadPhoto (Mat frame)
        {

            // 预测
            try //io有概率炸，try一下
            {
                Net net = Net.ReadNetFromCaffe(RunPath + "\\Model.config", RunPath + "\\Model.bin");
                Mat inputblob = CvDnn.BlobFromImage(frame, scaleFactor, new OpenCvSharp.Size(width, height), meanVal, false);
                net.SetInput(inputblob, "data");
                Mat detection = net.Forward("detection_out");
                //检测
                Mat detectionMat = new Mat(detection.Size(2), detection.Size(3), MatType.CV_32F, detection.Ptr(0));
                float confidence_threshold = 0.3f;



                for (int i = 0; i < detectionMat.Rows; i++)
                {
                    float confidence = detectionMat.At<float>(i, 2);
                    if (confidence > confidence_threshold)
                    {

                        int objIndex = (int)(detectionMat.At<float>(i, 1));
                        float tl_x = detectionMat.At<float>(i, 3) * frame.Cols;
                        float tl_y = detectionMat.At<float>(i, 4) * frame.Rows;
                        float br_x = detectionMat.At<float>(i, 5) * frame.Cols;
                        float br_y = detectionMat.At<float>(i, 6) * frame.Rows;

                        Rect object_box = new Rect((int)tl_x, (int)tl_y, (int)(br_x - tl_x), (int)(br_y - tl_y));

                        Cv2.Rectangle(frame, object_box, new Scalar(0, 0, 255), 2, LineTypes.Link8, 0);


                        //----由于PutText方法不支持中文，因此需要使用系统自带的自绘GDI画笔
                        Cv2.PutText(frame, classNames[objIndex], new Point(tl_x, tl_y), HersheyFonts.HersheySimplex, 1.0, new Scalar(255, 0, 0), 2);
                        //第二个参数不能是""，也就是不能为空;
                        GDI:
                        {
                            _Image_Data_GDI.P = new PointF(tl_x + Math.Abs(MainForm.width - frame.Width), tl_y);

                            _Image_Data_GDI.text = classNames_cn[objIndex];

                            //g.DrawString(classNames_cn[objIndex], new Font("宋体", 20, FontStyle.Bold), new SolidBrush(Color.Black), tl_x, tl_y);

                        }
                        Label_识别到的物体名称.Text = $"识别到的物体:{classNames_cn[objIndex]}";
                    }

                    if (DllImport_Pro.DllImport_Pro.GetInputState() != 0)
                    {
                        DllImport_Pro.DllImport_Pro.PeekMessage();
                    }

                }
                //释放内存

                detection.Release();
                inputblob.Release();
                detectionMat.Release();
                net.Dispose();
                // if (Cv2.ImWrite(RunPath + "/image/temp/CameraTemp.jpg", frame) == false)
                //      MessageBox.Show("写文件错误", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //先把文件写出来再销毁内存
                /*

                frame.Release();
                /*老方法
                //文件流方式读图片，不用Fromfile，否则文件会被占用。
                FileStream fs = new FileStream(RunPath + "/image/temp/CameraTemp.jpg", FileMode.Open, FileAccess.Read);
                int byteLength = (int)fs.Length;
                byte[] fileBytes = new byte[byteLength];
                fs.Read(fileBytes, 0, byteLength);
                fs.Close();
                MainCamera.Image = System.Drawing.Image.FromStream(new MemoryStream(fileBytes));
                */
                return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
            }
            catch (Exception ex)
            {

                //异常处理
                MessageBox.Show("当你看到这个提示的时候程序并没有崩溃，只是遇到了一个问题\n" +
                    "错误原因：图片识别错误\n错误位置：" + ex.Message + "\n" + "" +
                    "解决办法：由于该错误是被Catch捕捉到的，因此并不影响程序运行，请更换图片尝试。", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //报错了，将空的图片返回，不要返回ToBitmap(frame)，否则try拦不住
                return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Cv2.ImRead(RunPath + "/image/none.png"));

            }

        }
        private void 关于本程序ToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Form_About form_temp;
            form_temp = new Form_About();
            form_temp.Show();
        }
        public void LoadList ()
        {
            Thread.Sleep(100);
        }
        public void LoadCameraList ()
        {

            摄像头选择.Items.Clear();
            foreach (var i in GetCamera.GetCamera.Devices)
            {
                摄像头选择.Items.Add(i);
            }
            if (摄像头选择.Items.Count == 0)
            {
                MessageBox.Show("没有搜索到摄像头，请检查连线是否有问题");
            }
            else
            {
                摄像头选择.SelectedIndex = 0;//默认移动第一个
            }
        }
        private void Timer_UpdatePhoto_Tick (object sender, EventArgs e)
        {
            FileStream fs = new FileStream(RunPath + "/image/temp/CameraTemp.jpg", FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] fileBytes = new byte[byteLength];
            fs.Read(fileBytes, 0, byteLength);
            fs.Close();
            MainCamera.Image = System.Drawing.Image.FromStream(new MemoryStream(fileBytes));
        }
        private void DisplayCamera (object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Read(frame); // 读取当前帧

            if (frame.Empty())
            {
                return; // 如果读取失败则跳过此帧
            }

            // 将图像转换为Bitmap格式以便于在Winform中显示
            System.Drawing.Bitmap bitmap = BitmapConverter.ToBitmap(frame);
            // MainCamera.Image = bitmap; // 在pictureBox控件上显示图像
            if (Form_Full.Visible == true)
                Form_Full.BackgroundImage = Thread_LoadPhoto(frame);
            else
                MainCamera.Image = Thread_LoadPhoto(frame);
        }


        private void 全屏检测ToolStripMenuItem_Click (object sender, EventArgs e)
        {
            if (bl_Camera == true)
            {
                Form_Full.Show();
            }
            else
            {
                MessageBox.Show("请先开启视频实时检测功能再打开全屏模式", "温馨提示");
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                bl_Camera = true;
                capture = new VideoCapture(index_cmarea); // 0代表默认的摄像头设备编号
                capture.Open(index_cmarea);
                Application.Idle += DisplayCamera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click (object sender, EventArgs e)
        {
            capture.Release();
            bl_Camera = false;

            FileStream fs = new FileStream(RunPath + "/image/none.png", FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] fileBytes = new byte[byteLength];
            fs.Read(fileBytes, 0, byteLength);
            fs.Close();
            MainCamera.Image = System.Drawing.Image.FromStream(new MemoryStream(fileBytes));

        }

        private void button3_Click (object sender, EventArgs e)
        {
            打开ToolStripMenuItem_Click(null, null);
        }

        private void MainForm_DragEnter (object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void MainForm_DragDrop (object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            PictureBoxImage.Image = Thread_LoadPhoto(Cv2.ImRead(files[0], ImreadModes.Color));
        }
        private void 摄像头选择_SelectedIndexChanged (object sender, EventArgs e)
        {
            index_cmarea = 摄像头选择.SelectedIndex;
        }

        private void PictureBoxImage_Click (object sender, EventArgs e)
        {

        }

        private void PictureBoxImage_Paint (object sender, PaintEventArgs e)
        {
            UpdateGDIText(e);
        }
        public void UpdateGDIText (PaintEventArgs _paintEventArgs)
        {
            Graphics g = _paintEventArgs.Graphics;
            Console.WriteLine(_Image_Data_GDI.P);

            g.DrawString(_Image_Data_GDI.text, new Font("宋体", 20, FontStyle.Bold), new SolidBrush(Color.Red), _Image_Data_GDI.P);
        }

        private void MainCamera_Paint (object sender, PaintEventArgs e)
        {
            UpdateGDIText(e);
        }
    }
}