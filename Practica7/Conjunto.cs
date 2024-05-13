using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Conjunto : Coleccionable, Iterable2,Ordenable
    {
        List<Comparable> lista_elementos;
        OrdenEnAula1 ordenDeInicio;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula2 ordenLlegaAlumno;
        public Conjunto()
        {
            this.lista_elementos = new List<Comparable>();
        }
        public List<Comparable> ListaElementos()
        {
            return this.lista_elementos;
        }
        public void agregar(Comparable c)
        {
            if (!pertenece(c))
            {
                lista_elementos.Add(c);
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
        }
        public bool pertenece(Comparable c)
        {
            foreach (Comparable a in lista_elementos)
            {
                if (c.sosIgual(a))
                {
                    return true;
                }
            }
            return false;
        }
        public int cuantos()
        {
            return this.lista_elementos.Count();
        }
        public Comparable minimo()
        {
            Comparable elemento_mas_chico = this.lista_elementos[0];
            for (int i = 1; i < this.lista_elementos.Count(); i++)
            {
                if (this.lista_elementos[i].sosMenor(elemento_mas_chico))
                {
                    elemento_mas_chico = this.lista_elementos[i];
                }
            }
            return elemento_mas_chico;
        }
        public Comparable maximo()
        {
            Comparable elemento_mas_grande = this.lista_elementos[0];
            for (int i = 1; i < this.lista_elementos.Count(); i++)
            {
                if (this.lista_elementos[i].sosMayor(elemento_mas_grande))
                {
                    elemento_mas_grande = this.lista_elementos[i];
                }
            }
            return elemento_mas_grande;
        }
        public void agregarColeccinable(Comparable c)
        {
            this.agregar(c);
        }
        public bool contiene(Comparable c)
        {
            return this.pertenece(c);
        }
        public Iterable crearIterable()
        {
            return new IterableConjunto(this);
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
