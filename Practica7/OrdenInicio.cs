using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class OrdenInicio : OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar()
        {
            this.aula.comenzar();
        }
    }
}
