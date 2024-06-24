using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_dethithu
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

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin", MessageBoxButtons.OK);
        }

        private void giảiPhươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ptbac2 Ptbac2 = new Ptbac2();
            Ptbac2.ShowDialog();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinhdang dinhdang = new dinhdang();
            dinhdang.ShowDialog();
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangky dangky = new dangky();
            dangky.ShowDialog();
        }
    }
}
