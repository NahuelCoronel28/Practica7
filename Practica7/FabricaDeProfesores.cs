using Practica7;
using ObtencionDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica4
{
    internal class FabricaDeProfesores : FabricaDeComparables
    {
        Manejador manejador = FabricaDeComparables.crearCadenaDeResponsable();
        public override Comparable crearAleatorio()
        {
            int numero_auxiliar = manejador.numeroPorTeclado();
            return new Profesor(manejador.stringAleatorio(numero_auxiliar), manejador.numeroAleatorio(numero_auxiliar), manejador.numeroAleatorio(numero_auxiliar));
        }
        public override Comparable crearPorTeclado()
        {
            return new Profesor(manejador.stringPorTeclado(), manejador.numeroPorTeclado(), manejador.numeroPorTeclado());
        }
        public override Comparable crearDesdeArchivo()
        {
            return new Profesor(manejador.stringDesdeArchivo(1), manejador.numeroDesdeArchivo(1), manejador.numeroDesdeArchivo(1));
        }
    }
}
