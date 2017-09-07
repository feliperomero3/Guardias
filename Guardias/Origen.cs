using System;

namespace Guardias
{
    /// <summary>
    /// Contiene las 6 listas de Area y la lista de Unidad.
    /// </summary>
    class Origen
    {
        private Lista<Lista<Area>> _areas;
        private Lista<Unidad> _unidades;

        public Lista<Lista<Area>> Areas
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
            // Una lista de seis listas de Áreas
            _areas = new Lista<Lista<Area>>();
            // Una lista para Unidades
            _unidades = new Lista<Unidad>();
        }

        /// <summary>
        /// Llena la lista de seis listas de Áreas y la lista de Unidades
        /// como corresponde.
        /// </summary>
        public void Inicializar()
        {
            if (_areas != null)
            {
                // Seis semanas
                for (int i = 0; i < Auxiliar.areas.Length; i++)
                {
                    Lista<Area> subAreas = new Lista<Area>();
                    // Semana i
                    foreach (Area area in Auxiliar.areas[i])
                    {
                        subAreas.Insertar(area);
                    }
                    subAreas.Padre = _areas;
                    _areas.Insertar(subAreas);
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
