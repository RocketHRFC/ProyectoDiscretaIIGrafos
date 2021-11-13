using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscretaIIGrafos
{
    public class TeoremasCiclo
    {
        public bool Teorema1()
        {
            Grafo grafo = new Grafo();

            int size = grafo.GetSize();
            int naristas = 0;

            int[][] aristas = new int[grafo.GetAristas()][];

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(grafo.getLista()[i][j] == 1)
                    {

                        if (VerticesSumados(aristas, i, j) == false)
                        {
                            int[] arista = new int[2] { i, j };
                            aristas[naristas] = arista;
                            naristas++;
                        }
                    }
                }
            }

        }

        public bool VerticesSumados(int[][] ListaAristas, int V1, int V2)
        {
            int size = ListaAristas.Length;

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; i < size; j++)
                {
                    int[] arista = new int[2] { V1, V2 };
                    int[] aristap = new int[2] { V2, V1 };

                    if (ListaAristas[i] == arista || ListaAristas[i] == aristap)
                    {
                        return true;
                    }
                } 
            }

            return false;
        }


    }
}
