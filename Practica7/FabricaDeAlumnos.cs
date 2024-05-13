using Practica7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FabricaDeAlumnos : FabricaDeComparables
    {
        Manejador manejador = FabricaDeComparables.crearCadenaDeResponsable();

        public override Comparable crearAleatorio()
        {
            int numero_auxiliar = manejador.numeroPorTeclado();
            return new Alumno(manejador.stringAleatorio(numero_auxiliar), manejador.numeroAleatorio(numero_auxiliar), manejador.numeroAleatorio(numero_auxiliar), manejador.numeroAleatorio(numero_auxiliar));
        }

        public override Comparable crearPorTeclado()
        {
            return new Alumno(manejador.stringPorTeclado(), manejador.numeroPorTeclado(), manejador.numeroPorTeclado(), manejador.numeroPorTeclado());
        }

        public override Comparable crearDesdeArchivo()
        {
            return new Alumno(manejador.stringDesdeArchivo(1), manejador.numeroDesdeArchivo(1), manejador.numeroDesdeArchivo(1), manejador.numeroDesdeArchivo(1));
        }
    }
}
