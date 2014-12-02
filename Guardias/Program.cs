using System;
using System.Linq;

namespace Guardias
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Inicializar();

            // Probar EF
            using (var db = new Context())
            {
                Console.WriteLine("Ingrese nombre de nueva Área: ");
                string nombre = Console.ReadLine();

                Area area = new Area { Nombre = nombre };

                db.Areas.Add(area);
                db.SaveChanges();

                // Mostrar
                var areas = from a in db.Areas
                            orderby a.Nombre
                            select a;
                foreach (var a in areas)
                {
                    Console.WriteLine("Todas las Áreas por orden alfabético:");
                    Console.WriteLine(a);
                }
            }
        }

        private static void Inicializar()
        {
            Origen origen = new Origen();
            origen.Inicializar();

            // Algoritmo principal.
            Nodo<Area> p = null;
            Nodo<Unidad> q = null;

            Lista<Area>[] areas = origen.Areas;
            Lista<Unidad> unidades = origen.Unidades;

            // Valores iniciales
            p = areas[0].Inicio;
            q = unidades.Inicio.Sig.Sig.Sig; // Unidad con Numero = 94 
            int dia, semana, diaTotal, semanaTotal;
            dia = semana = 0;
            diaTotal = semanaTotal = 1;
            string intervalo = string.Empty;
            DateTime fecha = new DateTime(2013, 12, 30);

            Console.WriteLine("Semana #{0} ({1})", 1, semanaTotal);
            Console.WriteLine("Día #{0} ({1}) - {2:f}", 1, diaTotal, fecha);

            while (true)
            {
                // Repetir por 6 semanas (6 listas de Área)
                while (semana < areas.Length)
                {
                    // Repetir por 7 días (semana)
                    while (dia < 7)
                    {
                        // Las primeras 19 áreas con 5 unidades
                        do
                        {
                            intervalo = string.Format("{0,44} - {1} {2} {3} {4} {5}",
                                p, q, q.Sig, q.Sig.Sig, q.Sig.Sig.Sig, q.Sig.Sig.Sig.Sig);
                            p = p.Sig;
                            q = q.Sig.Sig.Sig.Sig.Sig;
                            // Imprimir
                            Console.WriteLine(intervalo);
                        } while (p.Sig != areas[semana].Inicio);

                        // Caso especial: última área (20) con solo dos unidades
                        Console.WriteLine("{0,44} - {1} {2}\r\n\r\n", p, q, q.Sig);
                        Console.ReadKey();
                        fecha = fecha.AddDays(1);
                        dia++;
                        diaTotal++;

                        p = p.Sig; // lo mismo que hacer p = p.Inicio
                        q = q.Sig;

                        if (dia < 7)
                        {
                            // Caso especial: primera guardia del siguiente día
                            Console.WriteLine("Semana #{0} ({1})", semana + 1, semanaTotal);
                            Console.WriteLine("Día #{0} ({1})- {2:f}", dia + 1, diaTotal, fecha);
                            intervalo = string.Format("{0,44} - {1} {2} {3} {4} {5}",
                                p, q.Ant.Ant.Ant.Ant, q.Ant.Ant.Ant, q.Ant.Ant, q.Ant, q);
                            Console.WriteLine(intervalo);
                            p = p.Sig;
                            q = q.Sig;
                        }
                    }
                    semana++;
                    semanaTotal++;
                    if (semana < areas.Length)
                    {
                        dia = 0;
                        p = areas[semana].Inicio;
                        // Caso especial: primera guardia del siguiente día
                        Console.WriteLine("Semana #{0} ({1})", semana + 1, semanaTotal);
                        Console.WriteLine("Día #{0} ({1})- {2:f}", dia + 1, diaTotal, fecha);
                        intervalo = string.Format("{0,44} - {1} {2} {3} {4} {5}",
                            p, q.Ant.Ant.Ant.Ant, q.Ant.Ant.Ant, q.Ant.Ant, q.Ant, q);
                        Console.WriteLine(intervalo);
                        p = p.Sig;
                        q = q.Sig;
                    }
                } 
                semana = 0;
            }
        }
    }
}
