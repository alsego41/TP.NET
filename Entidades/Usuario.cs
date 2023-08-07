using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private Datos.Usuario UsuarioData;

        public Usuario()
        {
            //Cargar Datos de un usuario
            string eMail = Console.ReadLine().ToString();
            string apellido = Console.ReadLine().ToString();
            string nombre = Console.ReadLine().ToString();
            string nombreUsuario = Console.ReadLine().ToString();
            string contraseña;
            string confirmarContraseña;
            do
            {
                contraseña = Console.ReadLine().ToString();
                confirmarContraseña = Console.ReadLine().ToString();
            } while (contraseña != confirmarContraseña);
               

            //Enviar a Datos.Usuario
            Datos.Usuario usuario_data = new Datos.Usuario(apellido, nombre, contraseña, eMail, nombreUsuario);

            //cargar la instancia de Datos.Usuario como usuarioData
            this.UsuarioData = usuario_data;


        }
    }
}