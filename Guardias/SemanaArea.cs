using System;

namespace Guardias
{
    public class SemanaArea
    {
        private int _id;
        private int _posicion;

        private int _semanaId;
        private Semana _semana;
        private int _areaId;
        private  Area _area;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public int Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
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

    }
}
