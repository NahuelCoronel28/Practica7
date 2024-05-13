using ObtencionDeDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal abstract class Manejador
    {
        Manejador sucesor;
        public Manejador(Manejador manejador)
        {
            this.sucesor = manejador;
        }

        public int numeroAleatorio(int valor)
        {
           if(sucesor != null)
           {
                return sucesor.numeroAleatorio(valor);
           }
           return 0;
        }

        public string stringAleatorio(int valor)
        {
            if (sucesor != null)
            {
                return sucesor.stringAleatorio(valor);
            }
            return "";
        }
        public int numeroPorTeclado()
        {
            if (sucesor != null)
            {
                return sucesor.numeroPorTeclado();
            }
            return 0;
        }

        public string stringPorTeclado()
        {
            if (sucesor != null)
            {
                return sucesor.stringPorTeclado();
            }
            return "";
        }

        public int numeroDesdeArchivo(int max)
        {
            if (sucesor != null)
            {
                return sucesor.numeroDesdeArchivo(max);
            }
            return 0;
        }

        public string stringDesdeArchivo(int cant)
        {
            if(sucesor != null)
            {
                return sucesor.stringDesdeArchivo(cant);
            }
            return "";
        }


    }
}
