namespace BMS_harasara
{
    partial class ProductsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsUC));
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.productidtxt = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.catagorytxt = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton3 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.savebutton = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.searchbutton = new WindowsFormsControlLibrary1.BunifuThinButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid1
            // 
            this.datagrid1.AllowUserToDeleteRows = false;
            this.datagrid1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.datagrid1.Location = new System.Drawing.Point(346, 14);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ReadOnly = true;
            this.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid1.Size = new System.Drawing.Size(278, 330);
            this.datagrid1.TabIndex = 1;
            this.datagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.datagrid1.Click += new System.EventHandler(this.datagrid1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Name";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(72, 36);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 36);
            this.nametxt.TabIndex = 4;
            this.nametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // productidtxt
            // 
            this.productidtxt.Location = new System.Drawing.Point(72, 97);
            this.productidtxt.Name = "productidtxt";
            this.productidtxt.Size = new System.Drawing.Size(100, 20);
            this.productidtxt.TabIndex = 6;
            this.productidtxt.TextChanged += new System.EventHandler(this.productidtxt_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(58, 13);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Product ID";
            // 
            // catagorytxt
            // 
            this.catagorytxt.Location = new System.Drawing.Point(72, 146);
            this.catagorytxt.Multiline = true;
            this.catagorytxt.Name = "catagorytxt";
            this.catagorytxt.Size = new System.Drawing.Size(100, 44);
            this.catagorytxt.TabIndex = 8;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 149);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 13);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Catagory";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(192, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuThinButton3
            // 
            this.bunifuThinButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton3.BackgroundImage")));
            this.bunifuThinButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton3.ButtonText = "Insert Image";
            this.bunifuThinButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton3.ForeColor = System.Drawing.Color.SeaShell;
            this.bunifuThinButton3.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton3.Iconimage = null;
            this.bunifuThinButton3.IconVisible = true;
            this.bunifuThinButton3.IconZoom = 90D;
            this.bunifuThinButton3.ImageIconOverlay = false;
            this.bunifuThinButton3.Location = new System.Drawing.Point(228, 199);
            this.bunifuThinButton3.Name = "bunifuThinButton3";
            this.bunifuThinButton3.Size = new System.Drawing.Size(112, 69);
            this.bunifuThinButton3.TabIndex = 10;
            this.bunifuThinButton3.Click += new System.EventHandler(this.bunifuThinButton3_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebutton.BackgroundImage")));
            this.savebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebutton.ButtonText = "Save";
            this.savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebutton.ForeColor = System.Drawing.Color.Honeydew;
            this.savebutton.ForeColorHoverState = System.Drawing.Color.White;
            this.savebutton.Iconimage = null;
            this.savebutton.IconVisible = true;
            this.savebutton.IconZoom = 90D;
            this.savebutton.ImageIconOverlay = false;
            this.savebutton.Location = new System.Drawing.Point(72, 308);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(87, 36);
            this.savebutton.TabIndex = 11;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(72, 199);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(150, 93);
            this.descriptiontxt.TabIndex = 13;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 199);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Description";
            // 
            // searchbutton
            // 
            this.searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbutton.BackgroundImage")));
            this.searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbutton.ButtonText = "Search";
            this.searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbutton.ForeColor = System.Drawing.Color.SeaShell;
            this.searchbutton.ForeColorHoverState = System.Drawing.Color.White;
            this.searchbutton.Iconimage = null;
            this.searchbutton.IconVisible = true;
            this.searchbutton.IconZoom = 90D;
            this.searchbutton.ImageIconOverlay = false;
            this.searchbutton.Location = new System.Drawing.Point(180, 308);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(104, 36);
            this.searchbutton.TabIndex = 14;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // ProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.bunifuThinButton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.catagorytxt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.productidtxt);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.datagrid1);
            this.Name = "ProductsUC";
            this.Size = new System.Drawing.Size(627, 389);
            this.Load += new System.EventHandler(this.ProdutsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox productidtxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox catagorytxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton3;
        private WindowsFormsControlLibrary1.BunifuThinButton savebutton;
        private System.Windows.Forms.TextBox descriptiontxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuThinButton searchbutton;
    }
}
