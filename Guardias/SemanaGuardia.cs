using System;

namespace Guardias
{
    public class SemanaGuardia
    {
        private int _id;

        private int _semanaId;
        private Semana _semana;
        private int _guardiaId;
        private Guardia _guardia;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int SemanaId
        {
            get { return _semanaId; }
            set { _semanaId = value; }
        }

        public virtual Semana Semana
        {
            get { return _semana; }
            set { _semana = value; }
        }

        public int GuardiaId
        {
            get { return _guardiaId; }
            set { _guardiaId = value; }
        }

        public virtual Guardia Guardia
        {
            get { return _guardia; }
            set { _guardia = value; }
        }

    }
}
