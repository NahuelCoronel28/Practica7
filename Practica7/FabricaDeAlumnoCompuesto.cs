using Practica4;
using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6___Primera_Parte
{
    internal class FabricaDeAlumnoCompuesto : FabricaDeAlumnos
    {
        IAlumno alumno;
        public FabricaDeAlumnoCompuesto(AlumnoProxy alumno)
        {
            this.alumno = alumno;
        }
        public AlumnoCompuesto creadorDeAlumnoCompuestos()
        {
            AlumnoCompuesto alumnoCompuesto = new AlumnoCompuesto();
            alumnoCompuesto.agregar(this.alumno);
            return alumnoCompuesto;
        }
    }
}
