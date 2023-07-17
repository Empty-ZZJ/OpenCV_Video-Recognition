using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OpenCvSharp;
using VideoSystem;

namespace LoadCmaera
{
    public class Program
    {
        public static void Main2 ()
        {
            VideoCapture capture = new VideoCapture(0); // 打开默认摄像头
            Mat frame = new Mat();

            if (!capture.IsOpened())
            {
                Console.WriteLine("无法打开摄像头！");
                return;
            }

            while (true)
            {
                capture.Read(frame); // 读取摄像头帧

                Bitmap bitmap = new Bitmap(frame.Cols, frame.Rows, System.Drawing.Imaging.PixelFormat.Format24bppRgb); // 创建位图对象
                BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat); // 锁定位图像素数据

                int stride = bmpData.Stride;
                IntPtr ptrBmp = bmpData.Scan0;
                IntPtr ptrImage = frame.Data;

                for (int i = 0; i < frame.Rows; i++)
                {
                    
                    byte[] data = new byte[stride];
                    
                    Marshal.Copy((IntPtr)((int)ptrImage + i * frame.Step()), data, 0, stride); // 复制一行像素数据到字节数组
                    Marshal.Copy(data, 0, IntPtr.Add(ptrBmp, i * stride), stride);
                }

                bitmap.UnlockBits(bmpData); // 解锁位图像素数据
                
                pictureBox.Image = bitmap;

                if (frame.Empty())
                {
                    break;
                }
            }

            capture.Release(); // 释放摄像头
        }
    }

}

