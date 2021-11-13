using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscretaIIGrafos
{
    public class TeoremasCiclo
    {
        public bool OysteinOre(ref Grafo grafo)
        {
            int size = grafo.GetSize();
            
            Grafo Vertices_NoAdyacentes= new Grafo();

            Vertices_NoAdyacentes.inicializarLista(ref Vertices_NoAdyacentes.getLista(), size);

            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        if (grafo.getLista()[i][j] == 0)
                        {
                            Vertices_NoAdyacentes.addArista(ref Vertices_NoAdyacentes.getLista(), i, j);
                            Vertices_NoAdyacentes.addArista(ref Vertices_NoAdyacentes.getLista(), j, i);
                        }
                    } 
                }
            }

            for(int i = 0; i < size;i++)
            {
                for(int j = 0; j < size;j++)
                {
                    if(Vertices_NoAdyacentes.getLista()[i][j] == 1)
                    {
                        if(grafo.GetGradosVertices()[i] + grafo.GetGradosVertices()[j] < size)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }    
    }
}
