using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica4;
using MetodologíasDeProgramaciónI;

namespace Practica5
{
    internal class AlumnoProxy : IAlumno
    {
        Alumno alumno_real = null;

        
        public string getNombre()
        {
            return this.alumno_real.getNombre();
        }
        public int getLegajo()
        {
            return this.alumno_real.getLegajo();
        }
        public int getPromedio()
        {
            return this.alumno_real.getPromedio();
        }
        public void setComparadorAlumno(ComparacionAlumno aux)
        {
            this.alumno_real.setComparadorAlumno(aux);
        }
        public void setCalificacion(int calificacion_aux)
        {
            this.alumno_real.setCalificacion(calificacion_aux);
        }
        public int getCalificacion()
        {
            return this.alumno_real.getCalificacion();
        }
        public bool sosIgual(Comparable c)
        {
            return this.alumno_real.sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            return this.alumno_real.sosMenor(c);
        }
        public bool sosMayor(Comparable c)
        {
            return this.alumno_real.sosMayor(c);
        }
        public void prestarAtencion()
        {
            this.alumno_real.prestarAtencion();
        }
        public void distraerse()
        {
            this.alumno_real.distraerse();
        }
        public void actualizar(Observado observado)
        {
            this.alumno_real.actualizar(observado);
        }
        public string ToString()
        {
            return this.alumno_real.ToString();
        }
        public int responderPregunta(int pregunta)
        {
            return this.alumno_real.responderPregunta(pregunta);
        }
        public string mostrarCalificacion()
        {
            if(this.alumno_real == null)
            {
                Console.WriteLine("Ingrese: 1) Para crear un Alumno, 2) Para crea un Alumno Muy Estudioso");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        Comparable comparable_auxiliar1 = FabricaDeComparables.crearDesdeArchivo(3);
                        alumno_real = ((Alumno)comparable_auxiliar1);
                        break;
                    case 2:
                        Comparable comparable_auxiliar2 = FabricaDeComparables.crearDesdeArchivo(5);
                        alumno_real = ((AlumnoMuyEstudioso)comparable_auxiliar2);
                        break;
                }
            }
            return this.alumno_real.mostrarCalificacion();  
        }
    }
}
