using System;
using System.Text;
using System.Collections.Generic;

namespace Guardias
{
    /// <summary>
    /// Lista circular dinámica (no genérica) de tipo T.
    /// </summary>
    /// <typeparam name="T">Cualquier primitivo o definido por el usuario</typeparam>
    class Lista<T>
    {
        private Nodo<T> _inicio;
        private Nodo<T> _fin;

        public Nodo<T> Inicio
        {
            get { return _inicio; }
            private set { _inicio = value; }
        }

        public Nodo<T> Fin
        {
            get { return _fin; }
            private set { _fin = value; }
        }

        public Lista()
        {
            _inicio = null;
        }

        // TODO comentar los métodos...
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        public void Insertar(T x)
        {
            Nodo<T> p = new Nodo<T>(x);
            if (_inicio == null)
            {
                _inicio = _fin = p;
                p.Sig = _inicio;
            }
            else
            {
                p.Sig = _inicio;
                _fin.Sig = p;
                _fin = p;
            }
        }

        public void Remover(T x)
        {
            // TODO: implementar Lista.Remover(T x)
        }

        public string Mostrar()
        {
            if (_inicio != null)
            {
                StringBuilder contenido = new StringBuilder();
                Nodo<T> q = _inicio;
                do
                {
                    contenido.AppendFormat("{0}\r\n", q.Entidad);
                    q = q.Sig;
                }
                while (q != _inicio);
                return contenido.ToString();
            }
            else
            {
                return "No existe lista circular.";
            }
        }
    }
}
