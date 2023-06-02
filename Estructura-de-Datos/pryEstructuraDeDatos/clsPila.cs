using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class clsPila
    {
        public clsNodo Primero;

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null) 
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar() 
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
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

        public void Recorrer(ListBox lista)
        {
            clsNodo aux = Primero;
            lista.Items.Clear();    
            while (aux != null)
            {
                lista.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while(aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }
}
