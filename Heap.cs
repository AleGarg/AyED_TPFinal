using System;
using System.Collections.Generic;
using tp1;

namespace tpfinal
{
    // Clase Heap auxiliar para el punto 1
    public class Heap
    {
        private List<Dato> elementos = new List<Dato>();
        public void Insertar(Dato d)
        {
            elementos.Add(d);
            SiftUp(elementos.Count - 1);
        }
        public Dato ExtraerMaximo()
        {
            if (elementos.Count == 0) return null;
            Dato max = elementos[0];
            elementos[0] = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            SiftDown(0);
            return max;
        }
        public bool EsVacia() => elementos.Count == 0;

        private void SiftUp(int i)
        {
            while (i > 0 && elementos[(i - 1) / 2].ocurrencia < elementos[i].ocurrencia)
            {
                var temp = elementos[i];
                elementos[i] = elementos[(i - 1) / 2];
                elementos[(i - 1) / 2] = temp;
                i = (i - 1) / 2;
            }
        }
        private void SiftDown(int i)
        {
            int max = i;
            int izq = 2 * i + 1;
            int der = 2 * i + 2;
            if (izq < elementos.Count && elementos[izq].ocurrencia > elementos[max].ocurrencia) max = izq;
            if (der < elementos.Count && elementos[der].ocurrencia > elementos[max].ocurrencia) max = der;
            if (max != i)
            {
                var temp = elementos[i];
                elementos[i] = elementos[max];
                elementos[max] = temp;
                SiftDown(max);
            }
        }
    }
}