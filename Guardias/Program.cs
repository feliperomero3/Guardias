using System;
using System.Globalization;

namespace Guardias
{
    class Program
    {
        private static CultureInfo esMx = new CultureInfo("es-MX");
        private static Origen origen = new Origen();
        private static string formato = "dddd dd/MMMM/yyyy";
        private static DateTime fecha = new DateTime(2013, 12, 30);
        private static Nodo<Lista<Area>> o;
        private static Nodo<Unidad> q;
        private static Nodo<Area> p;

        private static void Main(string[] args)
        {
            Inicializar();
            Looper();
        }

        private static void Looper()
        {
            Console.WriteLine("Ingrese opción deseada ");
            Console.WriteLine("A = avanzar, B = avanzar hasta fecha, X o ^C = cerrar");
            ConsoleKeyInfo tecla = Console.ReadKey(false);
            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Ejecutar(o, p, q, null);
                    break;
                case ConsoleKey.B:
                    Ejecutar(o, p, q, new DateTime(2014, 01, 30));
                    break;
                case ConsoleKey.X:
                    break;
                default:
                    break;
            }
        }

        private static void Inicializar()
        {
            origen.Inicializar();
            o = origen.Areas.Inicio; // Semana #1
            p = origen.Areas.Inicio.Entidad.Inicio; // ME Cabo
            q = origen.Unidades.Inicio.Sig.Sig.Sig.Sig.Sig; // 92
        }

        private static void Ejecutar(Nodo<Lista<Area>> o, Nodo<Area> p, Nodo<Unidad> q, DateTime? limite)
        {
            int semanas, dias;
            semanas = dias = 1;

            while (true)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine("Semana #{0} - ({1})", semanas, "indexOf");
                    Console.WriteLine("Día #{0} ({1}) - {2:f}", dias++, j + 1, 
                        fecha.ToString(formato, esMx));

                    // Caso especial: avance invertido (primera Área)
                    q = q.Sig;
                    Console.WriteLine("{0, 44} - {1} {2} {3} {4} {5}",
                        p, q, q.Ant, q.Ant.Ant, q.Ant.Ant.Ant, q.Ant.Ant.Ant.Ant);
                    p = p.Sig;
                    q = q.Sig;

                    // Caso normal: avanza cinco unidades
                    while (p.Sig != p.Padre.Inicio)
                    {
                        Console.WriteLine("{0, 44} - {1} {2} {3} {4} {5}",
                            p, q.Sig.Sig.Sig.Sig, q.Sig.Sig.Sig, q.Sig.Sig, q.Sig, q);
                        p = p.Sig;
                        q = q.Sig.Sig.Sig.Sig.Sig;
                    }

                    // Caso especial: avanza dos unidades (última Área)
                    Console.WriteLine("{0, 44} - {1} {2}\r\n\r\n", p, q.Sig, q);
                    ConsoleKeyInfo tecla = Console.ReadKey();
                    p = p.Sig;
                    fecha = fecha.AddDays(1);

                    if (tecla.Key == ConsoleKey.X || limite != null && fecha > limite.Value)
                    {
                        return;
                    }
                }
                o = o.Sig;
                p = o.Entidad.Inicio;
                semanas++;
            }
        }
    }
}
