﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Productos.Config;
using _01_Productos.Controllers;

namespace _01_Productos.Model

{
    internal class UsuarioModel
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public static UsuarioModel ValidarUsuario(string usuario, string contraseña)
        {
            string query = "SELECT ID, usuario, Rol FROM Usuarios WHERE usuario = @usuario AND contraseña = @contraseña";
            using (var com = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(query, com))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UsuarioModel
                            {
                                ID = reader.GetInt32(0),
                                Usuario = reader.GetString(1),
                                Rol = reader.GetString(2)
                            };
                        }
                    }

                }
                return null;

            }
        }
    }

}