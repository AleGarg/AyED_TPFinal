using System;
using System.Collections.Generic;
using tp1;

namespace tpfinal
{
    public class Estrategia
    {
        // 1. Buscar con Heap
        public void BuscarConHeap(List<string> datos, int cantidad, List<Dato> collected)
        {
            Dictionary<string, int> conteo = ContarPalabras(datos);
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

        private List<Dato> LlenarListaDatos(Dictionary<string, int> conteo)
        {
            List<Dato> lista = new List<Dato>();
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
        public String Consulta1(List<string> datos) { return "Implementar"; }
        public String Consulta2(List<string> datos) { return "Implementar"; }
        public String Consulta3(List<string> datos) { return "Implementar"; }
    }
}