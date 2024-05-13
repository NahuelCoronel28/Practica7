using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class OrdenAulaLlena : OrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }
}
