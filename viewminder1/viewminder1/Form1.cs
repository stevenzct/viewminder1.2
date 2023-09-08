using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewminder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            string hexColor = "#0A0C29";

            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);

            guna2Panel1.BackColor = myColor;
        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            

            string hexColor = "#2C81FF";

            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);

            guna2Button1.BackColor = myColor;
        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
