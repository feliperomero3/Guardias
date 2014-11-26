using System;

namespace Guardias
{
    class Guardia
    {
        private int _unidadId;
        private int _guardiaId;
        private DateTime _fecha;

        public int UnidadId
        {
            get { return _unidadId; }
            set { _unidadId = value; }
        }

        public int GuardiaId
        {
            get { return _guardiaId; }
            set { _guardiaId = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
    }
}
