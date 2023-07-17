namespace VideoSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全屏检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaintabControl = new System.Windows.Forms.TabControl();
            this.关于程序 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.照片识别 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.视频识别 = new System.Windows.Forms.TabPage();
            this.摄像头选择 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainCamera = new System.Windows.Forms.PictureBox();
            this.Timer_UpdatePhoto = new System.Windows.Forms.Timer(this.components);
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_识别到的物体名称 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.MaintabControl.SuspendLayout();
            this.关于程序.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.照片识别.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.视频识别.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.其他ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1387, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.打开ToolStripMenuItem.Text = "打开文件";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于本程序ToolStripMenuItem});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.其他ToolStripMenuItem.Text = "帮助";
            // 
            // 关于本程序ToolStripMenuItem
            // 
            this.关于本程序ToolStripMenuItem.Name = "关于本程序ToolStripMenuItem";
            this.关于本程序ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.关于本程序ToolStripMenuItem.Text = "关于本程序";
            this.关于本程序ToolStripMenuItem.Click += new System.EventHandler(this.关于本程序ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全屏检测ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 全屏检测ToolStripMenuItem
            // 
            this.全屏检测ToolStripMenuItem.Name = "全屏检测ToolStripMenuItem";
            this.全屏检测ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.全屏检测ToolStripMenuItem.Text = "全屏检测";
            this.全屏检测ToolStripMenuItem.Click += new System.EventHandler(this.全屏检测ToolStripMenuItem_Click);
            // 
            // MaintabControl
            // 
            this.MaintabControl.Controls.Add(this.关于程序);
            this.MaintabControl.Controls.Add(this.照片识别);
            this.MaintabControl.Controls.Add(this.视频识别);
            this.MaintabControl.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaintabControl.ItemSize = new System.Drawing.Size(30, 30);
            this.MaintabControl.Location = new System.Drawing.Point(12, 35);
            this.MaintabControl.Multiline = true;
            this.MaintabControl.Name = "MaintabControl";
            this.MaintabControl.SelectedIndex = 0;
            this.MaintabControl.Size = new System.Drawing.Size(1363, 786);
            this.MaintabControl.TabIndex = 1;
            // 
            // 关于程序
            // 
            this.关于程序.Controls.Add(this.label3);
            this.关于程序.Controls.Add(this.label2);
            this.关于程序.Controls.Add(this.label1);
            this.关于程序.Controls.Add(this.pictureBox1);
            this.关于程序.Location = new System.Drawing.Point(4, 34);
            this.关于程序.Name = "关于程序";
            this.关于程序.Size = new System.Drawing.Size(1355, 748);
            this.关于程序.TabIndex = 3;
            this.关于程序.Text = "关于程序";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::VideoSystem.Properties.Resources.LLL_0958;
            this.pictureBox1.Location = new System.Drawing.Point(477, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // 照片识别
            // 
            this.照片识别.Controls.Add(this.Label_识别到的物体名称);
            this.照片识别.Controls.Add(this.button3);
            this.照片识别.Controls.Add(this.PictureBoxImage);
            this.照片识别.Location = new System.Drawing.Point(4, 34);
            this.照片识别.Name = "照片识别";
            this.照片识别.Size = new System.Drawing.Size(1355, 748);
            this.照片识别.TabIndex = 1;
            this.照片识别.Text = "照片识别";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(13, 669);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 57);
            this.button3.TabIndex = 12;
            this.button3.Text = "选择文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxImage.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(1349, 660);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxImage.TabIndex = 11;
            this.PictureBoxImage.TabStop = false;
            this.PictureBoxImage.Click += new System.EventHandler(this.PictureBoxImage_Click);
            this.PictureBoxImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxImage_Paint);
            // 
            // 视频识别
            // 
            this.视频识别.Controls.Add(this.摄像头选择);
            this.视频识别.Controls.Add(this.button2);
            this.视频识别.Controls.Add(this.button1);
            this.视频识别.Controls.Add(this.MainCamera);
            this.视频识别.Location = new System.Drawing.Point(4, 34);
            this.视频识别.Name = "视频识别";
            this.视频识别.Size = new System.Drawing.Size(1355, 748);
            this.视频识别.TabIndex = 2;
            this.视频识别.Text = "视频识别";
            // 
            // 摄像头选择
            // 
            this.摄像头选择.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.摄像头选择.FormattingEnabled = true;
            this.摄像头选择.Location = new System.Drawing.Point(3, 3);
            this.摄像头选择.Name = "摄像头选择";
            this.摄像头选择.Size = new System.Drawing.Size(1349, 32);
            this.摄像头选择.TabIndex = 12;
            this.摄像头选择.SelectedIndexChanged += new System.EventHandler(this.摄像头选择_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(165, 664);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 57);
            this.button2.TabIndex = 11;
            this.button2.Text = "结束";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(9, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainCamera
            // 
            this.MainCamera.BackColor = System.Drawing.SystemColors.Window;
            this.MainCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainCamera.Location = new System.Drawing.Point(3, 33);
            this.MainCamera.Name = "MainCamera";
            this.MainCamera.Size = new System.Drawing.Size(1349, 625);
            this.MainCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainCamera.TabIndex = 10;
            this.MainCamera.TabStop = false;
            this.MainCamera.Paint += new System.Windows.Forms.PaintEventHandler(this.MainCamera_Paint);
            // 
            // Timer_UpdatePhoto
            // 
            this.Timer_UpdatePhoto.Tick += new System.EventHandler(this.Timer_UpdatePhoto_Tick);
            // 
            // MainImageList
            // 
            this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainImageList.Images.SetKeyName(0, "摄像机.ico");
            this.MainImageList.Images.SetKeyName(1, "home.png");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "能够识别的物体有";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(296, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 495);
            this.label2.TabIndex = 10;
            this.label2.Text = "飞机\r\n自行车\r\n鸟\r\n船\r\n瓶子\r\n公共汽车\r\n汽车\r\n猫\r\n椅子\r\n牛\r\n餐桌\r\n狗\r\n马\r\n摩托车\r\n人\r\n盆栽植物\r\n羊\r\n沙发\r\n火车\r\n显示器";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 495);
            this.label1.TabIndex = 9;
            this.label1.Text = "aeroplane\r\nbicycle\r\nbird\r\nboat\r\nbottle \r\nbus\r\ncar\r\ncat\r\nchair\r\ncow \r\ndiningtable\r" +
    "\ndog\r\nhorse\r\nmotorbike\r\nperson\r\npottedplant\r\nsheep\r\nsofa\r\ntrain\r\ntvmonito";
            // 
            // Label_识别到的物体名称
            // 
            this.Label_识别到的物体名称.AutoSize = true;
            this.Label_识别到的物体名称.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_识别到的物体名称.Location = new System.Drawing.Point(169, 688);
            this.Label_识别到的物体名称.Name = "Label_识别到的物体名称";
            this.Label_识别到的物体名称.Size = new System.Drawing.Size(178, 24);
            this.Label_识别到的物体名称.TabIndex = 13;
            this.Label_识别到的物体名称.Text = "识别到的物体：";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1387, 833);
            this.Controls.Add(this.MaintabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "物体识别与追踪系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MaintabControl.ResumeLayout(false);
            this.关于程序.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.照片识别.ResumeLayout(false);
            this.照片识别.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.视频识别.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本程序ToolStripMenuItem;
        private System.Windows.Forms.TabControl MaintabControl;
        private System.Windows.Forms.TabPage 照片识别;
        private System.Windows.Forms.Timer Timer_UpdatePhoto;
        private System.Windows.Forms.ImageList MainImageList;
        private System.Windows.Forms.TabPage 视频识别;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全屏检测ToolStripMenuItem;
        private System.Windows.Forms.TabPage 关于程序;
        private System.Windows.Forms.ComboBox 摄像头选择;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox MainCamera;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_识别到的物体名称;
    }
}

