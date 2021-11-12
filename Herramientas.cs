using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscretaIIGrafos
{
    public class Herramientas
    {
        public int[][] ObtenerGrafo(string path)
        {
            Grafo grafo = new Grafo();
            var lector = new StreamReader(File.OpenRead(path));

            int indicelinea = 0;

            while (!lector.EndOfStream)
            {
               
                var linea = lector.ReadLine();
                var valores = linea.Split(',');

                if(indicelinea == 0)
                {
                    int size = System.Convert.ToInt32(valores[0]);
                    //grafo.setSize(size);
                    grafo.inicializarLista(ref grafo.getLista(), size);
                }
                else
                {
                    int vOrigen = System.Convert.ToInt32(valores[0]);
                    int vDestino = System.Convert.ToInt32(valores[1]);

                    
                    grafo.addArista(ref grafo.getLista(), vOrigen, vDestino);
                }

                indicelinea++;
                
            }

            return grafo.getLista();
        }
    }
}
