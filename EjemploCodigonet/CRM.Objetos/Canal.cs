using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Objetos
{
    public class Canal
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

        public string medio;
        public string Medio
        {
            get { return medio; }
            set { medio = value; }
        }

        public string usu;
        public string Usu
        {
            get { return usu; }
            set { usu = value; }
        }
        public string bkp;
        public string Bkp
        {
            get { return bkp; }
            set { bkp = value; }
        }


    }
}
