using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StosMain : Form
    {
      //  private int childFormNumber = 0;

        public StosMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produktyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogAdm log = new LogAdm();
                log.TopLevel = true;
            log.Show();
            //Produkty pro = new Produkty();
            //pro.MdiParent = this;
            //pro.Show();
        }

        private void produktyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 pro = new Form5();
            pro.TopLevel = true;
            pro.Show();
        }

        private void koszykToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 pro = new Form6();
            pro.TopLevel = true;
            pro.Show();
        }
    }
}
