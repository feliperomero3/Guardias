using System;
using System.Collections.Generic;

namespace Guardias
{
    public class Unidad
    {
        private int _id;
        private int _numero;

        private List<Guardia> _guardias;

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

        public virtual List<Guardia> Guardias
        {
            get { return _guardias; }
            set { _guardias = value; }
        }

        public override string ToString()
        {
            return _numero.ToString().PadLeft(2);
        }
    }
}
