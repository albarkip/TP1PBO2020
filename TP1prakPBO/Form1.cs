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
    public partial class Form1 : Form
    {
        Login lgn = new Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void tombollogin_Click(object sender, EventArgs e)
        {
            lgn.loginnama = loginnama.Text;
            lgn.kuncilogin = loginkunci.Text;
            if (string.Compare(lgn.kuncilogin, "pbo123") != 0)
            {
                MessageBox.Show("login gagal!");
            }
            else
            {
                this.Hide();
                Form2 menu = new Form2();
                menu.Show();
            }
        }

        private void loginnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginkunci_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
