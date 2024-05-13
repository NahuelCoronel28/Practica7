using Practica4;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica6___Primera_Parte
{
    internal class AlumnoCompuesto : IAlumno
    {
        List<IAlumno> hijos;

        public AlumnoCompuesto()
        {
            hijos = new List<IAlumno>();
        }

        public void agregar(IAlumno alumno)
        {
            this.hijos.Add(alumno);
        }
        public string getNombre()
        {
            string nombre = "";
            foreach (IAlumno elemento in this.hijos)
            {
                nombre += "\n" + elemento.getNombre() ;
            }
            return nombre;
        }
        public int getLegajo()
        {
            return 0;
        }
        public int getPromedio()
        {
            return 0;
        }
        
        public void setComparadorAlumno(ComparacionAlumno aux)
        {
            foreach (IAlumno elemento in this.hijos)
            {
                elemento.setComparadorAlumno(aux);
            }
        }
        public void setCalificacion(int calificacion_aux)
        {
            foreach (IAlumno elemento in this.hijos)
            {
                elemento.setCalificacion(calificacion_aux);
            }
        }
        public int getCalificacion()
        {
            return 0;
        }
        public bool sosIgual(Comparable c)
        {
            bool indicador;
            foreach (IAlumno elemento in this.hijos)
            {
                if (elemento.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        public bool sosMenor(Comparable c)
        {
            int contador = 0;
            foreach (IAlumno elemento in this.hijos)
            {
                if (!elemento.sosMenor(c))
                {
                    contador++;
                }
            }
            return contador == 0;
        }
        public bool sosMayor(Comparable c)
        {
            int contador = 0;
            foreach (IAlumno elemento in this.hijos)
            {
                if (!elemento.sosMayor(c))
                {
                    contador++;
                }
            }
            return contador == 0;
        }
        public void prestarAtencion()
        {
            foreach (IAlumno elemento in this.hijos)
            {
                elemento.prestarAtencion();
            }
        }
        public void distraerse()
        {
            foreach (IAlumno elemento in this.hijos)
            {
                elemento.distraerse();
            }
        }
        public void actualizar(Observado observado)
        {
            foreach (IAlumno elemento in this.hijos)
            {
                elemento.actualizar(observado);
            }
        }
        public string ToString()
        {
            string nombre = "";
            foreach (IAlumno elemento in this.hijos)
            {
                nombre += "\n" + elemento.ToString();
            }
            return nombre;
        }
        public int responderPregunta(int pregunta)
        {
            int[] contador = new int[2];
            foreach(IAlumno elemento in this.hijos)
            {
                Random randomAux = new Random();
                int numerorandom = randomAux.Next(1, 2);
                if (numerorandom == 1)
                {
                    contador[0] =+ 1;
                }
                else
                {
                    contador[1] += +1;
                }
            }
            if (contador[0] > contador[1])
            {
                return contador[0];
            }
            if (contador[0] < contador[1])
            {
                return contador[1];
            }
            return contador[new Random().Next(0, 1)];
        }
        public string mostrarCalificacion()
        {
            string calificacion = "";
            foreach (IAlumno elemento in this.hijos)
            {
                calificacion += "\n" + elemento.mostrarCalificacion();
            }
            return calificacion;
        }

    }
}
