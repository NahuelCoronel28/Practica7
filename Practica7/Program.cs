// See https://aka.ms/new-console-template for more information
using MetodologíasDeProgramaciónI;
using Practica4;
using Practica5;
using Practica6___Primera_Parte;

namespace Practica7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicioDeClases();

            Console.WriteLine("Hello world!");
        }
        public static void llenar(Coleccionable coleccionable_ejemplo, int opcion)
        {
            for (int i = 1; i <= 20; i++)
            {
                Comparable comparable_auxiliar1 = FabricaDeComparables.crearAleatorio(opcion);
                AlumnoAdapter alumno_aux = new AlumnoAdapter((Alumno)comparable_auxiliar1);
                coleccionable_ejemplo.agregar((Comparable)alumno_aux);
            }
        }


        public static void informar(Coleccionable coleccionable_ejemplo, int opcion)
        {
            Console.WriteLine("la cantidad es: " + coleccionable_ejemplo.cuantos());
            Console.WriteLine("el promedio minimo es: " + coleccionable_ejemplo.minimo());
            Console.WriteLine("el promedio maximo es: " + coleccionable_ejemplo.maximo());
            Comparable comparable_auxiliar = FabricaDeComparables.crearPorTeclado(opcion);
            Iterable2 aux = ((Iterable2)coleccionable_ejemplo);
            Iterable aux2 = aux.crearIterable();
            aux2.primero();
            while (!aux2.fin())
            {
                if ((aux2.actual().sosIgual(comparable_auxiliar)))
                {
                    Console.WriteLine("El elemento leído está en la colección");
                    return;
                }
                aux2.siguiente();
            }
            Console.WriteLine("El elemento leído no está en la colección");
        }

        public static void dictadoDeClase(Profesor profesor)
        {
            for (int i = 1; i <= 5; i++)
            {
                profesor.hablarALaClase();
                profesor.notificar();
                profesor.escribirEnElPizarron();
                profesor.notificar();
            }
        }
        public static void inicioDeClases()
        {
            Teacher profesor = new Teacher();


            for (int i = 1; i <= 5; i++)
            {
                Comparable comparable_auxiliar1 = FabricaDeComparables.crearAleatorio(3);
                AlumnoAdapter alumno_aux = new AlumnoAdapter((Alumno)comparable_auxiliar1);
                StudentsFactory a = new StudentsFactory(alumno_aux);
                profesor.goToClass(a.creadorDeDecoradores());
            }

            for (int i = 1; i <= 2; i++)
            {
                Comparable comparable_auxiliar2 = FabricaDeComparables.crearPorTeclado(5);
                AlumnoAdapter alumno_aux2 = new AlumnoAdapter((Alumno)comparable_auxiliar2);
                StudentsFactory b = new StudentsFactory(alumno_aux2);
                profesor.goToClass(b.creadorDeDecoradores());

            }

            AlumnoCompuesto alumnoCompuesto2 = new AlumnoCompuesto();
            for (int i = 1; i <= 5; i++)
            {
                AlumnoProxy proxy = new AlumnoProxy();
                AlumnoCompuesto alumnoCompuesto = new FabricaDeAlumnoCompuesto(proxy).creadorDeAlumnoCompuestos();
                alumnoCompuesto2.agregar(alumnoCompuesto);
            }
            alumnoCompuesto2.mostrarCalificacion();
            AlumnoAdapter alumno_aux3 = new AlumnoAdapter(alumnoCompuesto2);
            StudentsFactory c = new StudentsFactory(alumno_aux3);
            profesor.goToClass(c.creadorDeDecoradores());




            //for (int i = 1; i <= 10; i++)
            //{
            //    Comparable comparable_auxiliar1 = FabricaDeComparables.crearAleatorio(3);
            //    AlumnoAdapter alumno_aux = new AlumnoAdapter((Alumno)comparable_auxiliar1);
            //    StudentsFactory a = new StudentsFactory(alumno_aux);
            //    profesor.goToClass(a.creadorDeDecoradores());
            //    Comparable comparable_auxiliar2 = FabricaDeComparables.crearAleatorio(5);
            //    AlumnoAdapter alumno_aux2 = new AlumnoAdapter((Alumno)comparable_auxiliar2);
            //    StudentsFactory b = new StudentsFactory(alumno_aux2);
            //    profesor.goToClass(b.creadorDeDecoradores());

            //}
            profesor.teachingAClass();


        }
    }
}