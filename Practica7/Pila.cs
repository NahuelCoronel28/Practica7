using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica5;
using MetodologíasDeProgramaciónI;

namespace Practica4
{
    internal class Pila : Coleccionable, Iterable2, Ordenable
    {
        OrdenEnAula1 ordenDeInicio;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula2 ordenLlegaAlumno;
        List<Comparable> elementos_pila;

        public Pila()
        {
            elementos_pila = new List<Comparable>();
            
        }
        public List<Comparable> Elementos_pila()
        {
            return this.elementos_pila;
        }

        public void apilar(Comparable c)
        {
            this.elementos_pila.Add(c);
        }
        public Comparable desapilar()
        {
            Comparable elemento_guardado = this.elementos_pila[elementos_pila.Count - 1];
            this.elementos_pila.RemoveAt(this.elementos_pila.Count - 1);
            return elemento_guardado;
        }

        public int cuantos()
        {
            return this.elementos_pila.Count();
        }
        public Comparable minimo()
        {
            Comparable elemento_mas_chico = this.elementos_pila[0];
            for (int i = 1; i < this.elementos_pila.Count(); i++)
            {
                if (this.elementos_pila[i].sosMenor(elemento_mas_chico))
                {
                    elemento_mas_chico = this.elementos_pila[i];
                }
            }
            return elemento_mas_chico;
        }
        public Comparable maximo()
        {
            Comparable elemento_mas_grande = this.elementos_pila[0];
            for (int i = 1; i < this.elementos_pila.Count(); i++)
            {
                if (this.elementos_pila[i].sosMayor(elemento_mas_grande))
                {
                    elemento_mas_grande = this.elementos_pila[i];
                }
            }
            return elemento_mas_grande;
        }
        public void agregar(Comparable c)
        {
            this.apilar(c);
            if (this.cuantos() == 1)
            {
                this.ordenDeInicio.ejecutar();
            }
            ordenLlegaAlumno.ejecutar(c);
            if (this.cuantos() == 40)
            {
                ordenAulaLlena.ejecutar();
            }
        }
        public bool contiene(Comparable c)
        {
            foreach (Comparable ele in this.elementos_pila)
            {
                if (ele.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        public Iterable crearIterable()
        {
            return new IterablePila(this);
        }

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            this.ordenDeInicio = orden;
        }
        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }
        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }
    }
}
