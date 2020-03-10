using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1prakPBO
{
    public partial class Form2 : Form
    {
        DetailBarang[] allbar = new DetailBarang[5];
        public Form2()
        {
            InitializeComponent();
            labelsemuabarang.Show();
            labelhasilcari.Hide();
            labeldetail.Hide();
            ddjenis.Items.Add("Baju");
            ddjenis.Items.Add("Elektronik");
            ddjenis.Items.Add("Makanan");

            ddrange.Items.Add("100000-200000");
            ddrange.Items.Add("200000-500000");
            ddrange.Items.Add("500000-1000000");

            allbar[0] = new DetailBarang("supreme", 1000000, "Baju");
            allbar[1] = new DetailBarang("Samsung", 400000, "Elektronik");
            allbar[2] = new DetailBarang("Nike", 700000, "Baju");
            allbar[3] = new DetailBarang("Rendang", 150000, "Makanan");
            allbar[4] = new DetailBarang("Risoles", 300000, "Makanan");
            semuamuncul();
        }

        private void tombolbeli_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2 a = new Form2();
            a.Show();
        }

        private void tombolkatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjVhvP3lY_oAhVFqZYKHf0rDWIYABAAGgJ0bA&ohost=www.google.com&cid=CAESQeD26FIGdocz753DcCLTh67cQ7UmV6o1FK-xvD28_ROqe-0mf0BtFHy2KWc7RUSeBzvzHchatkCNkqiNlWRKmhp5&sig=AOD64_2FyFF5zfOopKZPKpIIsOgUKRJkBw&q=&ved=2ahUKEwjY7Or3lY_oAhW3zIsBHfbtBw4Q0Qx6BAggEAE&adurl=");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ddrange_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tombollogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void labelsemuabarang_Click(object sender, EventArgs e)
        {

        }

        private void tombolcari_Click(object sender, EventArgs e)
        {
            labelsemuabarang.Hide();
            labelhasilcari.Show();
            panel1.Controls.Clear();
            tampilcari(ddjenis.Text, ddrange.Text);
            
        }
        public void tampilcari(String a, String b)
        {
            int count = 0;
            foreach(var x in allbar)
            {
                if(x.tipe == ddjenis.Text)
                {
                    if(ddrange.Text == "100000-200000")
                    {
                        if(x.harga >= 100000 && x.harga <= 200000)
                        {
                            panel1.FlowDirection = FlowDirection.TopDown;
                            PictureBox picbox = addPicture(count);
                            Label nambar = addLabel(x.namaBarang);
                            Label harbar = addLabel(Convert.ToString(x.harga));
                            panel1.Controls.Add(picbox);
                            panel1.Controls.Add(nambar);
                            panel1.Controls.Add(harbar);
                        }
                    }
                    else if(ddrange.Text == "200000-500000")
                    {
                        if (x.harga >= 200000 && x.harga <= 500000)
                        {
                            panel1.FlowDirection = FlowDirection.TopDown;
                            PictureBox picbox = addPicture(count);
                            Label nambar = addLabel(x.namaBarang);
                            Label harbar = addLabel(Convert.ToString(x.harga));
                            panel1.Controls.Add(picbox);
                            panel1.Controls.Add(nambar);
                            panel1.Controls.Add(harbar);
                        }
                    }
                    else if(ddrange.Text == "500000-1000000")
                    {
                        if (x.harga >= 500000 && x.harga <= 1000000)
                        {
                            panel1.FlowDirection = FlowDirection.TopDown;
                            PictureBox picbox = addPicture(count);
                            Label nambar = addLabel(x.namaBarang);
                            Label harbar = addLabel(Convert.ToString(x.harga));
                            panel1.Controls.Add(picbox);
                            panel1.Controls.Add(nambar);
                            panel1.Controls.Add(harbar);
                        }
                    }
                    
                }
                count++;
            }
        }
        private void b1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("keklik yang b1");
        }
        private void addButton(int c)
        {
            Button Mybutton = new Button();
            Mybutton.Location = new Point(225, 198);
            Mybutton.Text = "Beli";
            Mybutton.AutoSize = true;
            Mybutton.BackColor = Color.LightBlue;
            Mybutton.Padding = new Padding(6);
            Mybutton.Font = new Font("Serif", 10);
            Mybutton.Name = "b" + c;
            Controls.Add(Mybutton);
            panel1.Controls.Add(Mybutton);
        }
        private void kliktb(int c)
        {
            panel1.FlowDirection = FlowDirection.TopDown;
            PictureBox picbox = addPicture(c);
            Label nambar = addLabel(allbar[c].namaBarang);
            Label harbar = addLabel(Convert.ToString(allbar[c].harga));
            panel1.Controls.Add(picbox);
            panel1.Controls.Add(nambar);
            panel1.Controls.Add(harbar);
            addButton(c);
        }
        private void semuamuncul()
        {
            int count = 0;
            foreach (var bar in allbar)
            {
                panel1.FlowDirection = FlowDirection.TopDown;
                PictureBox picbox = addPicture(count);
                Label nambar = addLabel(bar.namaBarang);
                Label harbar = addLabel(Convert.ToString(bar.harga));
                panel1.Controls.Add(picbox);
                panel1.Controls.Add(nambar);
                panel1.Controls.Add(harbar);
                addButton(count);
                count++;
            }
        }
        Label addLabel(string nama)
        {
            Label lbl = new Label();
            lbl.Name = "allbar" + nama;
            lbl.Text = nama;
            lbl.ForeColor = Color.Black;
            lbl.Font = new Font("Serif", 12, FontStyle.Regular);
            lbl.TextAlign = ContentAlignment.BottomCenter;
            lbl.Margin = new Padding(5);

            return lbl;
        }

        PictureBox addPicture(int i)
        {
            i++;
            PictureBox picbox = new PictureBox();
            picbox.ImageLocation = "../../Properties/" + i + ".png";
            picbox.Size = new Size(90, 90);

            return picbox;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
