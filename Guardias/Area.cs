using System;
using System.Collections.Generic;

namespace Guardias
{
    public class Area
    {
        private int _id;
        private string _nombre;
        private string _nombreCorto;

        private List<Guardia> _guardias;
        private List<SemanaArea> _semanasAreas;

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
            get { return _nombreCorto; }
            set { _nombreCorto = value; }
        }

        public virtual List<Guardia> Guardias
        {
            get { return _guardias; }
            set { _guardias = value; }
        }

        public virtual List<SemanaArea> SemanasAreas
        {
            get { return _semanasAreas; }
            set { _semanasAreas = value; }
        }

        public override string ToString()
        {
            return _nombre;
        }
    }
}
