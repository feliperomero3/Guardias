using System;

namespace Guardias
{
    public class Area
    {
        private int _id;
        private string _nombre;
        private string _apodo;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apodo
        {
            get { return _apodo; }
            set { _apodo = value; }
        }

        public override string ToString()
        {
            return _nombre;
        }
    }
}
