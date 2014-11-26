using System;
using System.Collections.Generic;

namespace Guardias
{
    /// <summary>
    /// Nodo de tipo T para usar junto con @@link Lista.cs
    /// </summary>
    /// <typeparam name="T">Cualquier primitivo o definido por el usuario</typeparam>
    class Nodo<T>
    {
        private T _entidad;
        private Nodo<T> _sig;

        public Nodo(T x)
        {
            _entidad = x;
            _sig = null;
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
    }
}
