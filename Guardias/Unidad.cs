using System;

namespace Guardias
{
    public class Unidad
    {
        private int _id;
        private int _numero;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public override string ToString()
        {
            return _numero.ToString().PadLeft(2);
        }
    }
}
