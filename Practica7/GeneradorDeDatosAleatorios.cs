using Practica7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class GeneradorDeDatosAleatorios : Manejador
    {
        Manejador sucesor;
        static GeneradorDeDatosAleatorios instancia = null;
        public GeneradorDeDatosAleatorios(Manejador manejador) : base (manejador)
        {
            this.sucesor = manejador;
        }
        public int numeroAleatorio(int valor)
        {
            Random randomAux = new Random();
            return randomAux.Next(0, valor);
        }

        public string stringAleatorio(int valor)
        {
            string palabraMuestra = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string palabraputero = "";
            string palabraprogreso = "";
            for (int i = 0; i <= valor - 1; i++)
            {
                palabraputero = palabraMuestra[i].ToString();
                palabraprogreso = palabraprogreso + palabraputero;
            }
            return palabraprogreso;
        }

        public static GeneradorDeDatosAleatorios getInstance(Manejador m)
        {
            if(instancia == null)
            {
                instancia = new GeneradorDeDatosAleatorios(m);
            }
            return instancia;
        }

    }
}
