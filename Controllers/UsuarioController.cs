using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Productos.Model;
namespace _01_Productos.Controllers
{
    internal class UsuarioController
    {
        public static UsuarioModel AutenticarUsuario(string usuario, string contraseña)
        {
            return UsuarioModel.ValidarUsuario (usuario, contraseña);
        }

    }
}
