using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Productos.Controllers;
using _01_Productos.Views;


namespace _01_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            var usuario = UsuarioController.AutenticarUsuario(Usuario, Contraseña);
            if (usuario != null)
            {
                MessageBox.Show($"Biembenido {usuario.Usuario}.Rol: {usuario.Rol}");
                switch (usuario.Rol)
                {
                    case "Administrador":
                        frm_Admin frm_Admin = new frm_Admin();
                        frm_Admin.Show();
                        this.Hide();

                        break;
                }
    
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.");
            }
        }
    }
}
