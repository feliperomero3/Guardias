using System;
using System.Collections.Generic;

namespace Guardias
{
    public class Semana
    {
        private int _Id;
        private int _numero;

        private List<SemanaArea> _semanasAreas;
        private List<SemanaGuardia> _semanasGuardias;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public virtual List<SemanaArea> SemanasAreas
        {
            get { return _semanasAreas; }
            set { _semanasAreas = value; }
        }

        public virtual List<SemanaGuardia> SemanasGuardias
        {
            get { return _semanasGuardias; }
            set { _semanasGuardias = value; }
        }
    }
}
