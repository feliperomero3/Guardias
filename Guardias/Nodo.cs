using System;

namespace Guardias
{
    /// <summary>
    /// Nodo de tipo T para usar junto con Lista circular
    /// </summary>
    /// <typeparam name="T">Cualquier primitivo o definido por el usuario</typeparam>
    public class Nodo<T>
    {
        private Lista<T> _padre;
        private T _entidad;
        private Nodo<T> _sig;
        private Nodo<T> _ant;

        public Lista<T> Padre
        {
            get { return _padre; }
            set { _padre = value; }
        }

        public T Entidad
        {
            get { return _entidad; }
            set { _entidad = value; }
        }

        public Nodo<T> Sig
        {
            get { return _sig; }
            set { _sig = value; }
        }

        public Nodo<T> Ant
        {
            get { return _ant; }
            set { _ant = value; }
        }

        public Nodo(T x)
        {
            _entidad = x;
            _sig = null;
        }

        public override string ToString()
        {
            return _entidad.ToString();
        }
    }
}
