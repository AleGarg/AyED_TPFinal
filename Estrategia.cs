using System;
using System.Collections.Generic;
using tp1;

// TEMPORIZADORES
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace tpfinal
{
    public class Estrategia
    {
        // Creamos el cronómetro
        Stopwatch reloj = new Stopwatch();

        // 1. Buscar con Heap
        public void BuscarConHeap(List<string> datos, int cantidad, List<Dato> collected) // datos: lista de strings con los que trabaja (del csv), cantidad = barrita de búsqueda, collected = lista vacía de Dato(s), que luego vuelve con los resultados de los elementos más repetidos
        // ACÁ SE CARGAN LOS Dato EN collected:
        {
            Dictionary<string, int> conteo = ContarPalabras(datos); // Enviamos para contar el string<list> datos (del csv)
            List<Dato> listaDatos = LlenarListaDatos(conteo);

            Heap heap = new Heap();
            foreach (var d in listaDatos)
            {
                heap.Insertar(d);
            }

            for (int i = 0; i < cantidad && !heap.EsVacia(); i++)
            {
                collected.Add(heap.ExtraerMaximo());
            }
        }

        // 2. Buscar con Ordenamiento (QuickSort)
        public void BuscarConOtro(List<string> datos, int cantidad, List<Dato> collected)
        {
            Dictionary<string, int> conteo = ContarPalabras(datos);
            List<Dato> listaDatos = LlenarListaDatos(conteo);

            QuickSort(listaDatos, 0, listaDatos.Count - 1);

            for (int i = 0; i < cantidad && i < listaDatos.Count; i++)
            {
                collected.Add(listaDatos[i]);
            }
        }

        // --- MÉTODOS AUXILIARES ---

        private Dictionary<string, int> ContarPalabras(List<string> datos)
        {
            Dictionary<string, int> dicc = new Dictionary<string, int>();
            foreach (string s in datos)
            {
                if (dicc.ContainsKey(s)) dicc[s]++;
                else dicc[s] = 1;
            }
            return dicc;
        }

        private List<Dato> LlenarListaDatos(Dictionary<string, int> conteo) // Creamos una función para pasar el diccionario con la Palabra como Key y la iteración como el Value a una lista de Datos y de forma poder manejar mejor los datos 
        {
            List<Dato> lista = new List<Dato>();//Instanciamos la lista a usar
            foreach (var par in conteo)
            {
                // Cambiamos el orden: primero el Valor (int) y luego la Llave (string)
                lista.Add(new Dato(par.Value, par.Key));
            }
            return lista;
        }

        private void QuickSort(List<Dato> elementos, int izq, int der)
        {
            if (izq < der)
            {
                int pivote = Particionar(elementos, izq, der);
                QuickSort(elementos, izq, pivote - 1);
                QuickSort(elementos, pivote + 1, der);
            }
        }

        private int Particionar(List<Dato> elementos, int izq, int der)
        {
            // Usamos .ocurrencia (en singular)
            int pivotValue = elementos[der].ocurrencia;
            int i = (izq - 1);
            for (int j = izq; j < der; j++)
            {
                if (elementos[j].ocurrencia >= pivotValue) // Orden descendente
                {
                    i++;
                    var temp = elementos[i];
                    elementos[i] = elementos[j];
                    elementos[j] = temp;
                }
            }
            var temp2 = elementos[i + 1];
            elementos[i + 1] = elementos[der];
            elementos[der] = temp2;
            return i + 1;
        }

        // ESTO SE HACE DESPUÉS.
        // Consulta1 (List<string> datos): Retorna un texto con los tiempos que insumen los métodos BuscarConHeap() y BuscarConOrden() en realizar la búsqueda de los 5 elementos de con mayor cantidad de ocurrencias.
        public String Consulta1(List<string> datos)
        {
            // MATEO DEJA DE SEGUIRME POR EL AMOR DE DIOS ME SIENTO MUY SEGUIDO :'V
            List<Dato> collected = new List<Dato>();
            // --- EMPEZAMOS EL CRONOMETRO ---
            reloj.Start(); // Arranca el tiempo
            BuscarConHeap(datos, 5, collected);
            reloj.Stop(); // Frena el tiempo
            MessageBox.Show($"Tiempo HEAP: {reloj.Elapsed.TotalMilliseconds} ms");
            reloj.Reset();
            reloj.Start(); // Arranca el tiempo
            BuscarConOtro(datos, 5, collected);
            reloj.Stop(); // Frena el tiempo
            MessageBox.Show($"Tiempo Con otro: {reloj.Elapsed.TotalMilliseconds} ms");
            return "Implementar";
        }

        // Consulta2 (List<string> datos): Retorna un texto con el camino a la hoja más izquierda de la Heap que se construye a partir de los datos de entrada cuando se utiliza el método BuscarConHeap().
        public String Consulta2(List<string> datos)
        { // CONSULTA 2 ES LLAMADO DESDE BACKEND            
          // datos ES ------>      public static List<string> datos = new List<string>(); 
          // Nueva lista vacía de datos, que luego se carga con los datos del .csv
          // LOS DATOS SALEN DESDE FORM2, QUE LEE EL .CSV Y HACE EL PARSING



            // Base 0 (Raíz en i = 0): HijoIzquierdo(i) = 2i + 1
            // Base 1 (Raíz en i = 1): HijoIzquierdo(i) = 2i

            // while(i < datos.Count)
            // {

            // }

            List<string> vacio = new List<string>();

            // if(izq < der)
            // {
            //     vacio.Add(izq.Nombre);
            // }
            return "texto con el camino a la hoja";
        }

        // Consulta3 (List<string> datos): Retorna un texto que contiene los datos de la Heap que se construye a partir de los datos de entrada cuando se utiliza el método BuscarConHeap(), explicitando en el texto resultado los niveles en los que se encuentran ubicados cada uno de los datos.
        public String Consulta3(List<string> datos)

        {
            list<dato> lista = Armarheap(datos);

            if (lista.count == 0) return "esta vacio";

            for (int i = 0; i < lista.count++i)
            {
                int nivel = (int)Math.Log2(i + 1); // Calcula el nivel del nodo en la heap

                reporte.Appendline($"Nivel {nivel}: {lista[i].ToString()}");
            }
            return reporte.ToString();

        }
        private List<dato> ArmarEstructuraHeap(List<string> datos)
        {
            Dictionary<string, int> conteo = new Dictionary<string, int>();
            foreach (string s in datos)
            {
                if (conteo.ContainsKey(s)) conteo[s]++;
                else conteo[s] = 1;

                Heap heap = new Heap();
                foreach (var entry in conteo)
                {
                    heap.Insertar(new Dato(entry.Value, entry.Key));

                    return heap.ObtenerElementos();


                }
            }
        }
    }
}