using System;
using System.Globalization;

namespace Guardias
{
    class Program
    {
        private static CultureInfo esMx = new CultureInfo("es-MX");
        private static Origen origen = new Origen();
        private static string formato = "dddd dd/MMMM/yyyy";

        private static void Main(string[] args)
        {
            Ejecutar();
        }

        private static void Ejecutar()
        {
            origen.Inicializar();

            Nodo<Unidad> q = origen.Unidades.Inicio.Sig.Sig.Sig.Sig.Sig; // 92
            DateTime fecha = new DateTime(2013, 12, 30);
            int semanas, dias;
            semanas = dias = 1;

            while (true)
            {
                for (int i = 0; i < origen.Areas.Length; i++)
                {
                    Nodo<Area> p = origen.Areas[i].Inicio;

                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine("Semana #{0} - ({1})", semanas, i + 1);
                        Console.WriteLine("Día #{0} ({1}) - {2:f}", dias++, j + 1, 
                            fecha.ToString(formato, esMx));

                        // Caso especial: avance invertido (primera Área)
                        q = q.Sig;
                        Console.WriteLine("{0, 44} - {1} {2} {3} {4} {5}",
                            p, q, q.Ant, q.Ant.Ant, q.Ant.Ant.Ant, q.Ant.Ant.Ant.Ant);
                        p = p.Sig;
                        q = q.Sig;

                        // Caso normal: avanza cinco unidades
                        while (p.Sig != origen.Areas[i].Inicio)
                        {
                            Console.WriteLine("{0, 44} - {1} {2} {3} {4} {5}",
                                p, q.Sig.Sig.Sig.Sig, q.Sig.Sig.Sig, q.Sig.Sig, q.Sig, q);
                            p = p.Sig;
                            q = q.Sig.Sig.Sig.Sig.Sig;
                        }

                        // Caso especial: avanza dos unidades (última Área)
                        Console.WriteLine("{0, 44} - {1} {2}\r\n\r\n", p, q.Sig, q);
                        Console.ReadKey();
                        p = p.Sig;
                        fecha = fecha.AddDays(1);
                    }
                    semanas++;
                }
            }
        }
    }
}
