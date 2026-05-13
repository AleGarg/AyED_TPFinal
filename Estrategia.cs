
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using tp1;

namespace tpfinal
{

	public class Estrategia
	{
	
		public String Consulta1(List<string> datos)
		{
			string result = "Implementar";
            return result;
		}


		public String Consulta2(List<string> datos)
		{
			string result = "Implementar";
            
            return result;
        }

		

		public String Consulta3(List<string> datos)
		{
			string result = "Implementar";

            return result;
		}



        // Sinceramente, no sé si BuscarConOtro es igual a BuscarConOrden, o si hay que hacer un void nuevo...
        // 2. BuscarConOrden(List<string> datos, int cantidad, List<Dato> collected): Tiene la misma funcionalidad del método BuscarConHeap() pero debe implementarse utilizando un método ordenamiento de los vistos en clase el que sea de su preferencia.

        public void BuscarConOtro(List<string> datos, int cantidad, List<Dato> collected)
        {
            //Implementar
        }


        // ACÁ SE TRABAJA:
        // 1. BuscarConHeap(List<string> datos, int cantidad, List<Dato> collected): Retorna en la variable collected los primeros elementos con mayor número de ocurrencias de la lista datos utilizando una Heap como estructura de datos soporte. El número de elementos a retornar es indicado por el parámetro cantidad.

        public void BuscarConHeap(List<string> datos, int cantidad, List<Dato> collected)
        {
            //Implementar
        }




    }
}