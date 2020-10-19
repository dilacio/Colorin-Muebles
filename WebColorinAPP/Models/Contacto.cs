using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebColorinAPP.Models
{
    public class Contacto
    {
        public String Nombre { get; set; }
        public String Mail { get; set; }
        public int Telefono { get; set; }
        public String Mensaje { get; set; }

        public Contacto(string nombre, string mail, int telefono, string mensaje)
        {
            Nombre = nombre;
            Mail = mail;
            Telefono = telefono;
            Mensaje = mensaje;
        }

        public Contacto()
        {
        }
    }
}