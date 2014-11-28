﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Guardias
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Áreas para ejemplo rápido (no olvidar aprender TDD)
            Area a1 = new Area() { Id = 1, Nombre = "Casa Dorada", Apodo = "CS" };
            Area a2 = new Area() { Id = 2, Nombre = "Fiestamericana", Apodo = "FA" };
            Area a3 = new Area() { Id = 3, Nombre = "Finisterra", Apodo = "FT" };
            
            Lista<Area> areas = new Lista<Area>();
            areas.Insertar(a1);
            areas.Insertar(a2);
            areas.Insertar(a3);

            string contenido = areas.Mostrar();
            Console.WriteLine(contenido);
            Console.WriteLine(string.Format("Nodo _inicio: {0}", areas.Inicio.Entidad));
            Console.WriteLine(string.Format("Nodo _fin: {0}", areas.Fin.Entidad));

            Console.ReadKey();
            Inicializar();
        }

        private static void Inicializar()
        {
            Origen origen = new Origen();
            origen.Inicializar();
            Console.WriteLine(origen.Unidades.Mostrar());
            Console.WriteLine(origen.Areas[0].Mostrar());
            Console.ReadKey();

        }
    }
}
