using System;

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
            Console.WriteLine(string.Format("Nodo _fin: {0}\r\n", areas.Fin.Entidad));

            Console.ReadKey();
            Inicializar();
        }

        private static void Inicializar()
        {
            Origen origen = new Origen();
            origen.Inicializar();
            //Console.WriteLine(origen.Unidades.Mostrar());
            //Console.WriteLine(origen.Areas[0].Mostrar());
            //Console.ReadKey();

            // Algoritmo principal.
            Nodo<Area> p = null;
            Nodo<Unidad> q = null;

            Lista<Area> areas = origen.Areas[0];
            Lista<Unidad> unidades = origen.Unidades;

            // Valores iniciales
            p = areas.Inicio;
            q = unidades.Inicio.Sig.Sig.Sig; // Unidad con Numero = 94 
            int dia = 0; // Lunes
            string intervalo = string.Empty;

            Console.WriteLine("Día #1");

            // Repetir por 7 días (semana)
            while (dia < 7)
            {
                // Las primeras 19 áreas con 5 unidades
                do
                {
                    intervalo = string.Format("{0,40} - {1} {2} {3} {4} {5}",
                        p, q, q.Sig, q.Sig.Sig, q.Sig.Sig.Sig, q.Sig.Sig.Sig.Sig);
                    p = p.Sig;
                    q = q.Sig.Sig.Sig.Sig.Sig;
                    // Imprimir
                    Console.WriteLine(intervalo);
                } while (p.Sig != areas.Inicio);

                // Caso especial: última área (20) con solo dos unidades
                Console.WriteLine("{0,40} - {1} {2}\r\n", p, q, q.Sig);
                Console.ReadKey();
                dia++;
                
                p = p.Sig; // lo mismo que hacer p = p.Inicio
                q = q.Sig;

                if (dia < 7)
                {
                    Console.WriteLine(string.Format("Día #{0}\r\n", dia + 1));
                    // Caso especial: primera guardia del siguiente día
                    intervalo = string.Format("{0,40} - {1} {2} {3} {4} {5}",
                        p, q, q.Ant, q.Ant.Ant, q.Ant.Ant.Ant, q.Ant.Ant.Ant.Ant);
                    Console.WriteLine(intervalo);
                }

                p = p.Sig;
                q = q.Sig;
            }
        }
    }
}
