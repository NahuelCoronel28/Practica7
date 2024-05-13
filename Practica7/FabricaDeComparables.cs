using ObtencionDeDatos;
using Practica7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal abstract class FabricaDeComparables : IFabricaDeComparables
    {
        public static Comparable crearAleatorio(int opcion)
        {

            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDePersonas();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 4:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDePersonas();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 4:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
            }
            return fabrica.crearPorTeclado();
        }
        public static Comparable crearDesdeArchivo(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDePersonas();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 4:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
            }
            return fabrica.crearDesdeArchivo();
        }
        abstract public Comparable crearAleatorio();

        abstract public Comparable crearPorTeclado();
        abstract public Comparable crearDesdeArchivo();
        public static Manejador crearCadenaDeResponsable()
        {
            Manejador cadena = GeneradorDeDatosAleatorios.getInstance(null);
            cadena = LectorDeDatos.getInstance(cadena);
            cadena = new LectorDeArchivos(cadena); 
            return cadena;
        }

    }
}
