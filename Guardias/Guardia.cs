using System;

namespace Guardias
{
    public class Guardia
    {
        private int _id;
        private int _unidadId;
        private int _areaId;
        private DateTime _fecha;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int UnidadId
        {
            get { return _unidadId; }
            set { _unidadId = value; }
        }

        public int GuardiaId
        {
            get { return _areaId; }
            set { _areaId = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
    }
}
