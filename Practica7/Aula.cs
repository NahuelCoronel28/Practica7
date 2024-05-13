using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;
using Practica4;
namespace Practica5
{
    internal class Aula
    {
        Teacher profesor;
        
        public void comenzar()
        {
            profesor = new Teacher();
            Console.WriteLine("Comenzandola clase");
        }

        public void nuevoAlumno(AlumnoAdapter alumno)
        {
            profesor.goToClass(alumno);
        }

        public void claseLista()
        {
            profesor.teachingAClass();
        }

    }
}
