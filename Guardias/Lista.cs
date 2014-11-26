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

        public Lista()
        {
            _inicio = null;
        }

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

        public string Mostrar()
        {
            if (_inicio != null)
            {
                StringBuilder contenido = new StringBuilder();
                Nodo<T> q = _inicio;
                do
                {
                    contenido.AppendFormat("{0}, ", q.Entidad);
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
