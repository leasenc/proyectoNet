using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Objetos
{
    public class Usuario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
    }
}
