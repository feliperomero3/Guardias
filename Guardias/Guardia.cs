using System;
using System.Collections.Generic;

namespace Guardias
{
    public class Guardia
    {
        private int _id;
        private DateTime _fecha;

        private int _unidadId;
        private Unidad _unidad;
        private int _areaId;
        private Area _area;
        private List<SemanaGuardia> _semanaGuardia;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int UnidadId
        {
            get { return _unidadId; }
            set { _unidadId = value; }
        }

        public virtual Unidad Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        public int AreaId
        {
            get { return _areaId; }
            set { _areaId = value; }
        }

        public virtual Area Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public virtual List<SemanaGuardia> SemanaGuardia
        {
            get { return _semanaGuardia; }
            set { _semanaGuardia = value; }
        }
    }
}
