using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica4
{
    internal class Diccionario : Coleccionable, Iterable2, Ordenable
    {
        List<ClaveValor> diccionarioejemplo;
        Conjunto conjuntoclaves;
        OrdenEnAula1 ordenDeInicio;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula2 ordenLlegaAlumno;
        public Diccionario()
        {
            conjuntoclaves = new Conjunto();
            diccionarioejemplo = new List<ClaveValor>();
        }
        public List<ClaveValor> DiccionarioEjemplo()
        {
            return this.diccionarioejemplo;
        }
        public void agregar(int clave, Comparable comparable)
        {
            Numero numero = new Numero(clave);
            if (!conjuntoclaves.pertenece(numero))
            {
                conjuntoclaves.agregar(numero);
                ClaveValor valorAgregar = new ClaveValor(numero, comparable);
                diccionarioejemplo.Add(valorAgregar);
            }
            else
            {
                while (conjuntoclaves.pertenece(numero) != true)
                {
                    int nuevoclave = numero.getValor() + 1;
                    numero.setValor(nuevoclave);
                }
                conjuntoclaves.agregar(numero);
                ClaveValor valorAgregar = new ClaveValor(numero, comparable);
                diccionarioejemplo.Add(valorAgregar);

            }
        }

        public Comparable valorDe(int clave)
        {
            Numero aux = new Numero(clave);
            foreach (ClaveValor a in diccionarioejemplo)
            {
                if (a.getClave().sosIgual(aux))
                {
                    return a.getValor();
                }
            }
            return null;
        }

        public int cuantos()
        {
            return this.diccionarioejemplo.Count();
        }
        public Comparable minimo()
        {
            Comparable elemento_mas_chico = this.diccionarioejemplo[0].getValor();
            for (int i = 1; i < this.diccionarioejemplo.Count(); i++)
            {
                if (this.diccionarioejemplo[i].getValor().sosMenor(elemento_mas_chico))
                {
                    elemento_mas_chico = this.diccionarioejemplo[i].getValor();
                }
            }
            return elemento_mas_chico;
        }
        public Comparable maximo()
        {
            Comparable elemento_mas_grande = this.diccionarioejemplo[0].getValor();
            for (int i = 1; i < this.diccionarioejemplo.Count(); i++)
            {
                if (this.diccionarioejemplo[i].getValor().sosMayor(elemento_mas_grande))
                {
                    elemento_mas_grande = this.diccionarioejemplo[i].getValor();
                }
            }
            return elemento_mas_grande;
        }
        public void agregar(Comparable c)
        {
            int indice = this.cuantos();
            agregar(indice, c);
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
            foreach (ClaveValor aux in diccionarioejemplo)
            {
                if (aux.getValor() == c)
                {
                    return true;
                }
            }
            return false;
        }
        public Iterable crearIterable()
        {
            return new IterableDiccionario(this);
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
