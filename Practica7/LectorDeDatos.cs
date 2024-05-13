using Practica7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class LectorDeDatos : Manejador
    {
        Manejador sucesor;
        static LectorDeDatos instancia = null;
        private LectorDeDatos (Manejador manejador) : base(manejador) 
        {
            this.sucesor = manejador;
        }
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        public string stringPorTeclado()
        {
            string cadena = Console.ReadLine();
            return cadena;
        }

        public static LectorDeDatos getInstance(Manejador m)
        {
            if(instancia == null)
            {
                instancia = new LectorDeDatos(m);
            }
            return instancia;
        }
    }
}
