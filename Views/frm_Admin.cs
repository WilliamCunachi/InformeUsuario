using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Productos.Views
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void conductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_agregar_c frm_Agregar_C = new frm_agregar_c();
            frm_Agregar_C.Show();
            this.Hide();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Informe frm_Informer = new frm_Informe ();
            frm_Informer.Show();
            this.Hide();
        }
    }
}
