using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Usuario
    {
        private string Apellido;
        private string Nombre;
        private string Clave;
        private string Mail;
        private bool Habilitada = false;
        private string NombreUsuario;

        public Usuario(string apellido, string nombre, string clave, string mail, string nombreUsuario)
        {
            //Cargar los datos ya verificados
            Apellido = apellido;
            Nombre = nombre;
            Clave = clave;
            Mail = mail;
            NombreUsuario = nombreUsuario;

            //Cargar al BD
            //TO DO
        }
    }
}