using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Objetos
{
    public class Objetivo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool flagGeneral;
        public bool FlagGeneral
        {
            get { return flagGeneral; }
            set { flagGeneral = value; }
        }

        public int codGeneral;
        public int CodGeneral
        {
            get { return codGeneral; }
            set { codGeneral = value; }
        }
    }
}
