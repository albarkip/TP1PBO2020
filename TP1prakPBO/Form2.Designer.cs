namespace TP1prakPBO
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tombolbeli = new System.Windows.Forms.Button();
            this.tombolkatalog = new System.Windows.Forms.Button();
            this.tombollogout = new System.Windows.Forms.Button();
            this.ddrange = new System.Windows.Forms.ComboBox();
            this.ddjenis = new System.Windows.Forms.ComboBox();
            this.tombolcari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelsemuabarang = new System.Windows.Forms.Label();
            this.labelhasilcari = new System.Windows.Forms.Label();
            this.labeldetail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tombolbeli
            // 
            this.tombolbeli.Image = ((System.Drawing.Image)(resources.GetObject("tombolbeli.Image")));
            this.tombolbeli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tombolbeli.Location = new System.Drawing.Point(52, 125);
            this.tombolbeli.Name = "tombolbeli";
            this.tombolbeli.Size = new System.Drawing.Size(174, 50);
            this.tombolbeli.TabIndex = 0;
            this.tombolbeli.Text = "menu beli";
            this.tombolbeli.UseVisualStyleBackColor = true;
            this.tombolbeli.Click += new System.EventHandler(this.tombolbeli_Click);
            // 
            // tombolkatalog
            // 
            this.tombolkatalog.Image = ((System.Drawing.Image)(resources.GetObject("tombolkatalog.Image")));
            this.tombolkatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tombolkatalog.Location = new System.Drawing.Point(52, 181);
            this.tombolkatalog.Name = "tombolkatalog";
            this.tombolkatalog.Size = new System.Drawing.Size(174, 51);
            this.tombolkatalog.TabIndex = 1;
            this.tombolkatalog.Text = "menu katalog";
            this.tombolkatalog.UseVisualStyleBackColor = true;
            this.tombolkatalog.Click += new System.EventHandler(this.tombolkatalog_Click);
            // 
            // tombollogout
            // 
            this.tombollogout.Image = ((System.Drawing.Image)(resources.GetObject("tombollogout.Image")));
            this.tombollogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tombollogout.Location = new System.Drawing.Point(66, 417);
            this.tombollogout.Name = "tombollogout";
            this.tombollogout.Size = new System.Drawing.Size(142, 42);
            this.tombollogout.TabIndex = 2;
            this.tombollogout.Text = "logout";
            this.tombollogout.UseVisualStyleBackColor = true;
            this.tombollogout.Click += new System.EventHandler(this.tombollogout_Click);
            // 
            // ddrange
            // 
            this.ddrange.FormattingEnabled = true;
            this.ddrange.Location = new System.Drawing.Point(393, 67);
            this.ddrange.Name = "ddrange";
            this.ddrange.Size = new System.Drawing.Size(121, 21);
            this.ddrange.TabIndex = 3;
            this.ddrange.Text = "range harga";
            // 
            // ddjenis
            // 
            this.ddjenis.FormattingEnabled = true;
            this.ddjenis.Location = new System.Drawing.Point(266, 67);
            this.ddjenis.Name = "ddjenis";
            this.ddjenis.Size = new System.Drawing.Size(121, 21);
            this.ddjenis.TabIndex = 4;
            this.ddjenis.Text = "jenis barang";
            this.ddjenis.SelectedIndexChanged += new System.EventHandler(this.ddrange_SelectedIndexChanged);
            // 
            // tombolcari
            // 
            this.tombolcari.Location = new System.Drawing.Point(520, 67);
            this.tombolcari.Name = "tombolcari";
            this.tombolcari.Size = new System.Drawing.Size(52, 23);
            this.tombolcari.TabIndex = 5;
            this.tombolcari.Text = "search";
            this.tombolcari.UseVisualStyleBackColor = true;
            this.tombolcari.Click += new System.EventHandler(this.tombolcari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "1806384-Albari Berki Pradhana";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 93);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.tombolbeli);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tombolkatalog);
            this.splitContainer1.Panel1.Controls.Add(this.tombollogout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.labeldetail);
            this.splitContainer1.Panel2.Controls.Add(this.labelhasilcari);
            this.splitContainer1.Panel2.Controls.Add(this.labelsemuabarang);
            this.splitContainer1.Panel2.Controls.Add(this.ddrange);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.ddjenis);
            this.splitContainer1.Panel2.Controls.Add(this.tombolcari);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(929, 588);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 8;
            // 
            // labelsemuabarang
            // 
            this.labelsemuabarang.AutoSize = true;
            this.labelsemuabarang.Location = new System.Drawing.Point(28, 102);
            this.labelsemuabarang.Name = "labelsemuabarang";
            this.labelsemuabarang.Size = new System.Drawing.Size(77, 13);
            this.labelsemuabarang.TabIndex = 7;
            this.labelsemuabarang.Text = "semua barang:";
            this.labelsemuabarang.Click += new System.EventHandler(this.labelsemuabarang_Click);
            // 
            // labelhasilcari
            // 
            this.labelhasilcari.AutoSize = true;
            this.labelhasilcari.Location = new System.Drawing.Point(28, 102);
            this.labelhasilcari.Name = "labelhasilcari";
            this.labelhasilcari.Size = new System.Drawing.Size(84, 13);
            this.labelhasilcari.TabIndex = 8;
            this.labelhasilcari.Text = "Hasil Pencarian:";
            // 
            // labeldetail
            // 
            this.labeldetail.AutoSize = true;
            this.labeldetail.Location = new System.Drawing.Point(31, 101);
            this.labeldetail.Name = "labeldetail";
            this.labeldetail.Size = new System.Drawing.Size(74, 13);
            this.labeldetail.TabIndex = 10;
            this.labeldetail.Text = "Detail Barang:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 442);
            this.panel1.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 587);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolbeli;
        private System.Windows.Forms.Button tombolkatalog;
        private System.Windows.Forms.Button tombollogout;
        private System.Windows.Forms.ComboBox ddrange;
        private System.Windows.Forms.ComboBox ddjenis;
        private System.Windows.Forms.Button tombolcari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelsemuabarang;
        private System.Windows.Forms.Label labelhasilcari;
        private System.Windows.Forms.Label labeldetail;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}