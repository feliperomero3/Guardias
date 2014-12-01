using System;

namespace Guardias
{
    /// <summary>
    /// Contiene las 6 listas de Area y la lista de Unidad.
    /// </summary>
    class Origen
    {
        private Lista<Area>[] _areas;
        private Lista<Unidad> _unidades;

        public Lista<Area>[] Areas
        {
            get { return _areas; }
            set { _areas = value; }
        }

        public Lista<Unidad> Unidades
        {
            get { return _unidades; }
            set { _unidades = value; }
        }

        public Origen()
        {
            // 6 listas de Áreas
            _areas = new Lista<Area>[Auxiliar.areas.Length];
            // 1 lista para Unidades
            _unidades = new Lista<Unidad>();
        }

        /// <summary>
        /// Llena las 6 listas de Áreas y la lista de Unidades
        /// como corresponde.
        /// </summary>
        public void Inicializar()
        {
            if (_areas != null)
            {
                // Seis semanas
                for (int i = 0; i < _areas.Length; i++)
                {
                    // Semana i
                    _areas[i] = new Lista<Area>();
                    foreach (Area area in Auxiliar.areas[i])
                    {
                        _areas[i].Insertar(area);
                    }
                }
            }
            if (_unidades != null)
            {
                // Llenar lista de unidades
                _unidades = new Lista<Unidad>();
                foreach (Unidad unidad in Auxiliar.unidades)
                {
                    _unidades.Insertar(unidad);
                }
            }
        }
    }
}
