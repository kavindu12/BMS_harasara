namespace HarasaraIndustries
{
    partial class AdminMain
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.closeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.closeWindow);
            this.panel1.Controls.Add(this.minimizeWindow);
            this.panel1.Controls.Add(this.label1);
            this.animator1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 34);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(87, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Harasara Industries  (Pvt) Ltd";
            this.label4.UseWaitCursor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.animator1.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(957, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(141, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "August  20 2017";
            this.lblDate.UseWaitCursor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.animator1.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1127, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "22:22:22";
            this.lblTime.UseWaitCursor = true;
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.animator1.SetDecoration(this.closeWindow, BunifuAnimatorNS.DecorationType.None);
            this.closeWindow.Image = ((System.Drawing.Image)(resources.GetObject("closeWindow.Image")));
            this.closeWindow.ImageActive = null;
            this.closeWindow.Location = new System.Drawing.Point(1336, 3);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(26, 29);
            this.closeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindow.TabIndex = 2;
            this.closeWindow.TabStop = false;
            this.closeWindow.UseWaitCursor = true;
            this.closeWindow.Zoom = 10;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.animator1.SetDecoration(this.minimizeWindow, BunifuAnimatorNS.DecorationType.None);
            this.minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("minimizeWindow.Image")));
            this.minimizeWindow.ImageActive = null;
            this.minimizeWindow.Location = new System.Drawing.Point(1305, 2);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(25, 31);
            this.minimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeWindow.TabIndex = 2;
            this.minimizeWindow.TabStop = false;
            this.minimizeWindow.UseWaitCursor = true;
            this.minimizeWindow.Zoom = 10;
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(611, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.animator1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 727);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Promotions";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animator1.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 292);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(216, 70);
            this.bunifuFlatButton3.TabIndex = 0;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.UseWaitCursor = true;
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "System Admins";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animator1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 180);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(216, 80);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.UseWaitCursor = true;
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animator1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(57, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.UseWaitCursor = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "admin";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logged User";
            this.label2.UseWaitCursor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animator1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(215, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 694);
            this.panel3.TabIndex = 2;
            this.panel3.UseWaitCursor = true;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMain";
            this.Text = "Harasara Industries PVT LTD";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow;
        private Bunifu.Framework.UI.BunifuImageButton minimizeWindow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private BunifuAnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}

