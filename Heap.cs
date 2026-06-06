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
            Dato max = elementos[0]; // Agarra al que está en la posición 0 (EL MÁS REPETIDO)
            elementos[0] = elementos[elementos.Count - 1]; // Agarra al último elemento de la lista y lo sube a la posición 0
            elementos.RemoveAt(elementos.Count - 1); // Borra el último ya que está repetido
            SiftDown(0); // llamamos a SiftDown arrancando desde la posición 0 para que [elementos.Count - 1] "caiga" hasta su posición real.
            return max;
        }
        public bool EsVacia() => elementos.Count == 0;

        private void SiftUp(int i) // i es la posición (index) que recibimos según la cantidad de elementos -1
        {
            while (i > 0 && elementos[(i - 1) / 2].ocurrencia < elementos[i].ocurrencia) 
            // elementos[i]: El dato que acabamos de meter
            // elementos[(i - 1) / 2]: El padre de ese dato
            // Entonces, SI la cantidad de ocurrencias de mi PADRE es MENOR < a mi cantidad de ocurrencias:
            {
                var temp = elementos[i];
                elementos[i] = elementos[(i - 1) / 2];
                elementos[(i - 1) / 2] = temp;
                i = (i - 1) / 2;
            }
        }
        private void SiftDown(int i) // Revisa si el elemento es más chico que sus hijos, y si lo es, lo intercambia con el hijo más grande para que baje
        {
            int max = i;
            int izq = 2 * i + 1; // para saber en qué casillero está tu hijo izquierdo
            int der = 2 * i + 2; // para saber en qué casillero está tu hijo DERECHO
            if (izq < elementos.Count && elementos[izq].ocurrencia > elementos[max].ocurrencia) max = izq; // si izq es más grande, max es el nuevo hijo izq
            if (der < elementos.Count && elementos[der].ocurrencia > elementos[max].ocurrencia) max = der; // si der es más grande, max es el nuevo hijo derecho
            if (max != i) // acá se hace el swap, ya que el máximo cambió
            {
                var temp = elementos[i];
                elementos[i] = elementos[max];
                elementos[max] = temp;
                SiftDown(max);
            }
        }
        public List<Dato> ObtenerElementos()
        {
            // elementos es la List<Dato> con todos los datos, que tienen: ocurrencia, texto y descripcion
            return elementos;
        }
    }
}