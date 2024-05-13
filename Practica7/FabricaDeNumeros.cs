using Practica7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica4
{
    internal class FabricaDeNumeros : FabricaDeComparables
    {
        Manejador manejador = FabricaDeComparables.crearCadenaDeResponsable();
        public override Comparable crearAleatorio()
        {
            int numero_auxiliar = manejador.numeroPorTeclado();
            return new Numero(manejador.numeroAleatorio(numero_auxiliar));
        }
        public override Comparable crearPorTeclado()
        {
            return new Numero(manejador.numeroPorTeclado());
        }
        public override Comparable crearDesdeArchivo()
        {
            return new Numero(manejador.numeroDesdeArchivo(1));
        }

    }
}
