﻿using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Cola : Coleccionable, Iterable2, Ordenable
    {
        List<Comparable> elementos_cola;
        OrdenEnAula1 ordenDeInicio;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula2 ordenLlegaAlumno;
        public Cola()
        {
            this.elementos_cola = new List<Comparable>();
        }

        public List<Comparable> Elementos_cola()
        {
            return this.elementos_cola;
        }
        public void encolar(Comparable c)
        {
            this.elementos_cola.Add(c);
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
        public Comparable desencolar()
        {
            Comparable elemento_guardado = this.elementos_cola[0];
            this.elementos_cola.RemoveAt(0);
            return elemento_guardado;
        }
        public int cuantos()
        {
            return this.elementos_cola.Count();
        }
        public Comparable minimo()
        {
            Comparable elemento_mas_chico = this.elementos_cola[0];
            for (int i = 1; i < this.elementos_cola.Count(); i++)
            {
                if (this.elementos_cola[i].sosMenor(elemento_mas_chico))
                {
                    elemento_mas_chico = this.elementos_cola[i];
                }
            }
            return elemento_mas_chico;
        }
        public Comparable maximo()
        {
            Comparable elemento_mas_grande = this.elementos_cola[0];
            for (int i = 1; i < this.elementos_cola.Count(); i++)
            {
                if (this.elementos_cola[i].sosMayor(elemento_mas_grande))
                {
                    elemento_mas_grande = this.elementos_cola[i];
                }
            }
            return elemento_mas_grande;
        }
        public void agregar(Comparable c)
        {
            this.elementos_cola.Add(c);
        }
        public bool contiene(Comparable c)
        {
            foreach (Comparable ele in elementos_cola)
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
            return new IterableCola(this);
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
