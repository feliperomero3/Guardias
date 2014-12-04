using System;
using System.Globalization;

namespace Guardias
{
    class Program
    {
        private static CultureInfo esMx = new CultureInfo("es-MX");

        private static void Main(string[] args)
        {
            Inicializar(); 
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
            q = unidades.Inicio.Sig.Sig; // Unidad con Numero = 95
 
            int dia, semana, diaTotal, semanaTotal;
            dia = semana = 0;
            diaTotal = semanaTotal = 1;
            string intervalo = string.Empty;
            DateTime fecha = new DateTime(2013, 12, 30);

            Console.WriteLine("Semana #{0} ({1})", 1, semanaTotal);
            Console.WriteLine("Día #{0} ({1}) - {2:f}", 1, diaTotal, fecha.ToString("dddd dd/MMMM/yyyy", esMx));

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
                                p, q.Sig.Sig.Sig.Sig, q.Sig.Sig.Sig, q.Sig.Sig, q.Sig, q);
                            p = p.Sig;
                            q = q.Sig.Sig.Sig.Sig.Sig;
                            // Imprimir
                            Console.WriteLine(intervalo);
                        } while (p.Sig != areas[semana].Inicio);

                        // Caso especial: última área (20) con solo dos unidades
                        Console.WriteLine("{0,44} - {1} {2}\r\n\r\n", p, q.Sig, q);
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
                            Console.WriteLine("Día #{0} ({1}) - {2:f}", dia + 1, diaTotal, fecha.ToString("dddd dd/MMMM/yyyy", esMx));
                            intervalo = string.Format("{0,44} - {1} {2} {3} {4} {5}",
                                p, q, q.Ant, q.Ant.Ant, q.Ant.Ant.Ant, q.Ant.Ant.Ant.Ant);
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
                        Console.WriteLine("Día #{0} ({1}) - {2}", dia + 1, diaTotal, fecha.ToString("dddd dd/MMMM/yyyy", esMx));
                        intervalo = string.Format("{0,44} - {1} {2} {3} {4} {5}",
                            p, q, q.Ant, q.Ant.Ant, q.Ant.Ant.Ant, q.Ant.Ant.Ant.Ant);
                        Console.WriteLine(intervalo);
                        p = p.Sig;
                        q = q.Sig;
                    }
                } 
                semana = -1; // quick & dirty!
            }
        }
    }
}
