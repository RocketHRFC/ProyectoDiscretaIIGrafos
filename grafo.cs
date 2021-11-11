using System;

public class Grafo
{
	public Grafo()
	{
		int n; // n = cantidad de nodos (cantidad de vertices)

		// int[vertices de origen][vertices de destino]
		int[][] ListaAdy; //declaracion de jagged list, servira para crear una lista de adyacencia en forma de matriz


		//se define la matriz de tamaño n*n, se inicializa con todo ceros (sin aristas)
		//0 = no hay arista entre el vertice origen y el vertice destino
		//1 = si hay arista entre el vertice origen y el vertice destino
		//la lista se manda como referencia para que se guarden los cambios establecidos dentro de la funcion luego de que esta termine
		void inicializarLista(ref int[][] lista, int size)
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
		};

		//la lista se m anda como referencia para que se guarden los cambios establecidos dentro de la funcion luego de que esta termine
		// vOrigen es el vertice de donde se origina la arista
		// vDestino es el vertice al que llegue la arista
		void addArista(ref int[][] lista, int vOrigen, int vDestino)
        {
			lista[vOrigen][vDestino] = 1; // 1 simboliza la conexion entre vertice origen y destino creada por la arista
		};
	}
}
