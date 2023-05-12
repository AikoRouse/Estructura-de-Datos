using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;
        public clsNodo Primero
        {
            get { return pri; } 
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nvo)
        {
            if (Primero == null)
            {
                Primero = nvo;
                Ultimo = nvo;
            }
            else
            {
                if (nvo.Codigo < Primero.Codigo)
                {
                    nvo.Siguiente = Primero;
                    Primero.Anterior = nvo;
                    Primero = nvo;

                }
                else 
                {
                    if (nvo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nvo;
                        nvo.Anterior = Ultimo;
                        Ultimo = nvo;

                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < nvo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = nvo;
                        nvo.Siguiente = Aux;
                        Aux.Anterior = nvo;
                        nvo.Anterior = Ant;
                    }
                }
            }
        }

        

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }



        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }

        }

        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo Aux = Ultimo;
            Grilla.Rows.Clear();
            while(Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDes(ListBox Lista)
        {
            clsNodo Aux = ult;
            Lista.Items.Clear();
            while ( Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
                Aux= Aux.Anterior;  
            }
        }

        public void RecorrerDes (ComboBox Combo)
        {
            clsNodo Aux = Ultimo;
            Combo.Items.Clear();
            while( Aux != null)
            {
                Combo.Items.Add(Aux.Nombre);
                Aux = Aux.Anterior;
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if(Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if(Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;

                        }
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;
                    }
                    
                }
            }
        }
    }
}
