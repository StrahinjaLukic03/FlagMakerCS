using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            msMenu.ForeColor = Color.White;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void hSCbtn1of3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hPreviewBox1of3.BackColor = colorDialog1.Color;
        }

        private void hSCbtn2of3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hPreviewBox2of3.BackColor = colorDialog1.Color;
        }

        private void hSCbtn3of3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hPreviewBox3of3.BackColor = colorDialog1.Color;
        }

        private void hPrintbtn_Click(object sender, EventArgs e)
        {
            hPreviewBox1of3P.BackColor = hPreviewBox1of3.BackColor;
            hPreviewBox2of3P.BackColor = hPreviewBox2of3.BackColor;
            hPreviewBox3of3P.BackColor = hPreviewBox3of3.BackColor;

            //HorizontalTriColourFlag hTriFlag = new HorizontalTriColourFlag();
            //hTriFlag.Show();

            //hTriFlag.GethPreviewBox1of3P.SetBackColor = hPreviewBox1of3;
        }

    }
}
