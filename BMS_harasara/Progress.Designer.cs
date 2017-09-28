namespace BMS_harasara
{
    partial class Progress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progress));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuThinButton2 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cutting",
            "Painting",
            "Drilling",
            "Assembling",
            "Finishing"});
            this.checkedListBox1.Location = new System.Drawing.Point(320, 50);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(102, 124);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Update Progress";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(37, 138);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton1.TabIndex = 1;
            // 
            // bunifuThinButton2
            // 
            this.bunifuThinButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuThinButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton2.BackgroundImage")));
            this.bunifuThinButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton2.ButtonText = "Update Progress";
            this.bunifuThinButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton2.ForeColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton2.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton2.Iconimage = null;
            this.bunifuThinButton2.IconVisible = true;
            this.bunifuThinButton2.IconZoom = 90D;
            this.bunifuThinButton2.ImageIconOverlay = false;
            this.bunifuThinButton2.Location = new System.Drawing.Point(37, 60);
            this.bunifuThinButton2.Name = "bunifuThinButton2";
            this.bunifuThinButton2.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton2.TabIndex = 2;
            this.bunifuThinButton2.Click += new System.EventHandler(this.bunifuThinButton2_Click);
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.bunifuThinButton2);
            this.Controls.Add(this.bunifuThinButton1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Progress";
            this.Size = new System.Drawing.Size(627, 389);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton2;
    }
}
