﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea11
{
    public partial class FmrMenu : Form
    {
        public FmrMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FmrMenu_Load(object sender, EventArgs e)
        {

        }

        private void autobusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos frm = new FrmDatos();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
