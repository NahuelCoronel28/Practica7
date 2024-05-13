using Practica7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FabricaDePersonas : FabricaDeComparables
    {
        Manejador manejador = FabricaDeComparables.crearCadenaDeResponsable();
        public override Comparable crearAleatorio()
        {
            int numero_auxiliar = manejador.numeroPorTeclado();
            return new Persona(manejador.stringAleatorio(numero_auxiliar), manejador.numeroAleatorio(numero_auxiliar));
        }
        public override Comparable crearPorTeclado()
        {
            return new Persona(manejador.stringPorTeclado(), manejador.numeroPorTeclado());
        }
        public override Comparable crearDesdeArchivo()
        {
            return new Persona(manejador.stringAleatorio(1),manejador.numeroDesdeArchivo(1));
        }
    }
}
