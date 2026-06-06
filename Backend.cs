using System;
using tp1;

// TEMPORIZADORES
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace tpfinal
{ 
    public class Backend
    {
        // Creamos el cronómetro
        private static Stopwatch reloj = new Stopwatch();
        
        public static List<string> datos = new List<string>(); // Nueva lista vacía de datos, que luego se carga con los datos del .csv
        // LOS DATOS SALEN DESDE FORM2, QUE LEE EL .CSV Y HACE EL PARSING

        public static string aProfundidad()
        {
            return (new Estrategia()).Consulta3(datos);
        }

        public static string caminoAPrediccion()
        {
            return (new Estrategia()).Consulta2(datos);
        }

        public static string todasLasPredicciones()
        {
            return (new Estrategia()).Consulta1(datos);
        }

        public static void buscar(bool heapOP, int cantidad, List<Dato> collected)
        {
            Console.WriteLine("ESTAMOS BUSCANDOOOOOOOOOOO");
            
            if (heapOP) // si heapOP es true, es decir, el usuario quiere usar Heap:
            {
                // --- EMPEZAMOS EL CRONOMETRO ---
                reloj.Start(); // Arranca el tiempo
                (new Estrategia()).BuscarConHeap(datos, cantidad, collected); // Usamos la función BuscarConHeap y le pasamos
                reloj.Stop(); // Frena el tiempo
                Console.WriteLine($"Tiempo HEAP: {reloj.Elapsed.TotalMilliseconds} ms");
            }
            else // Si heapop era false:
            {
                (new Estrategia()).BuscarConOtro(datos, cantidad, collected);
            }
            
        }
    }

}