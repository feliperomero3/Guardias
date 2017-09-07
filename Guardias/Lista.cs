using System;
using System.Text;
using System.Collections.Generic;

namespace Guardias
{
    /// <summary>
    /// Lista circular dinámica (no genérica) de tipo T.
    /// </summary>
    /// <typeparam name="T">Cualquier primitivo o definido por el usuario</typeparam>
    public class Lista<T>
    {
        private Lista<Lista<T>> _padre;
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

        public Lista<Lista<T>> Padre
        {
            get { return _padre; }
            set { _padre = value; }
        }

        public Lista()
        {
            _inicio = null;
        }

        /// <summary>
        /// Inserta un nuevo elemento T en la lista
        /// </summary>
        /// <param name="x">Elemento a insertar</param>
        public void Insertar(T x)
        {
            Nodo<T> p = new Nodo<T>(x);
            p.Padre = this;
            if (_inicio == null)
            {
                _inicio = _fin = p;
                p.Sig = p.Ant  = _inicio;
            }
            else
            {
                p.Sig = _inicio;
                _inicio.Ant = p;
                _fin.Sig = p;
                p.Ant = _fin;
                _fin = p;
            }
        }

        public void Remover(T x)
        {
            // TODO: implementar Lista.Remover(T x)
        }

        /// <summary>
        /// Devuelve el Nodo ubicado en la posición indicada
        /// </summary>
        /// <param name="indice">Posición del Nodo</param>
        /// <returns>El Nodo o null si no existe</returns>
        public Nodo<T> Encontrar(int indice)
        {


            return null;
        }

        
        
        /// <summary>
        /// Devuelve el contenido de la lista
        /// </summary>
        /// <returns>La representación en texto del contenido</returns>
        public string Mostrar()
        {
            if (_inicio != null)
            {
                StringBuilder contenido = new StringBuilder();
                Nodo<T> q = _inicio;
                do
                {
                    contenido.AppendFormat("{0}\r\n", q);
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
