using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscretaIIGrafos
{
	public class Grafo
    {
		protected int n; // n = cantidad de nodos (cantidad de vertices)
		protected int e = 0; // e = cantidad de arístas
		// int[vertices de origen][vertices de destino]
		int[][] ListaAdy; //declaracion de jagged list, servira para crear una lista de adyacencia en forma de matriz


		//se define la matriz de tamaño n*n, se inicializa con todo ceros (sin aristas)
		//0 = no hay arista entre el vertice origen y el vertice destino
		//1 = si hay arista entre el vertice origen y el vertice destino
		//la lista se manda como referencia para que se guarden los cambios establecidos dentro de la funcion luego de que esta termine		
		public void inicializarLista(ref int[][] lista, int size)
		{
			lista = new int[size][]; // array de tamaño "size"

			for (int i = 0; i < size; i++)
			{
				lista[i] = new int[size]; //  cada vertice se le agrega un array de todos los vertices
			}

			// se llena la matriz con ceros (0), se inicializa solo con vertices y sin aristas
			for (int i = 0; i < size; i++)//recorre vertices origen
			{
				for (int j = 0; j < size; j++)//recorre vertices destino
				{
					lista[i][j] = 0; 
				}
			}
		}

		//la lista se manda como referencia para que se guarden los cambios establecidos dentro de la funcion luego de que esta termine
		// vOrigen es el vertice de donde se origina la arista
		// vDestino es el vertice al que llegue la arista
		public void addArista(ref int[][] lista, int vOrigen, int vDestino)
		{
			lista[vOrigen][vDestino] = 1; // 1 simboliza la conexion entre vertice origen y destino creada por la arista

			e++;
		}

		public ref int[][] getLista() // regresa la lista
		{
			return ref ListaAdy;
		}

		public void setSize(int size)// declara el numero de vertices
        {
			this.n = size;
        }

		public int GetSize()
        {
			return this.n;
        }

		public int GetAristas()
		{
			return this.e;
		}

		public Grafo() {} //constructor
	}
}
	