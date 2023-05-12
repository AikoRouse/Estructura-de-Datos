using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class ArbolBinario
    {
        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;

            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }

                }
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }


        public void Recorrer(ListBox lst)
        {
            lst.Items.Clear();
            InOrdenAsc(lst, Raiz);
        }
        public void InOrdenAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }


        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void InOrdenAsc(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
        }


        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }


        public void Recorrer(TreeView treeView)
        {
            treeView.Nodes.Clear();
            InOrdenAsc(treeView.Nodes, Raiz);
        }

        public void InOrdenAsc(TreeNodeCollection nodoPadre, clsNodo Raiz)
        {
            TreeNode nodonuevo = nodoPadre.Add(Raiz.Codigo.ToString());
            if (Raiz.Izquierdo != null) InOrdenAsc(nodonuevo.Nodes, Raiz.Izquierdo);

            if (Raiz.Derecho != null) InOrdenAsc(nodonuevo.Nodes, Raiz.Derecho);
        }
    
        public void RecorrerDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }

        public void InOrdenDes(ListBox lst, clsNodo R)
        {
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
        }


        public void RecorrerDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }

        public void InOrdenDes(ComboBox Combo, clsNodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
        }


        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }

        public void InOrdenDes(DataGridView Grilla, clsNodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
        }


        public void RecorrerDes(TreeView treeView)
        {
            treeView.Nodes.Clear();
            InOrdenDes(treeView.Nodes, Raiz);
        }

        public void InOrdenDes(TreeNodeCollection NodoPadre, clsNodo R)
        {
            if (R.Derecho != null) InOrdenAsc(NodoPadre, R.Derecho);
            TreeNode nodoNuevo = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(NodoPadre, R.Izquierdo);
        }
       
        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }

        public void PreOrden(ListBox lst, clsNodo R)
        {
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }


        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void PreOrden(ComboBox Combo, clsNodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void PreOrden(DataGridView Grilla, clsNodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
        }


        public void RecorrerPreOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PreOrden(treeView.Nodes, Raiz);
        }

        public void PreOrden(TreeNodeCollection NodoPadre, clsNodo R)
        {
            TreeNode nodoNuevo = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(nodoNuevo.Nodes, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(nodoNuevo.Nodes, R.Derecho);
        }
        
        
        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }

        public void PostOrden(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }

        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        public void PostOrden(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }


        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        public void PostOrden(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }


        public void RecorrerPostOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PostOrden(treeView.Nodes, Raiz);
        }

        public void PostOrden(TreeNodeCollection Npadre, clsNodo R)
        {
            TreeNode nodoNuevo = Npadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(nodoNuevo.Nodes, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(nodoNuevo.Nodes, R.Derecho);

        }
        
        private clsNodo[] vector = new clsNodo[100];
        private Int32 indice = 0;
        
        
        public void CargarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrden(NodoPadre.Izquierdo);
            }
            vector[indice] = NodoPadre;
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrden(NodoPadre.Derecho);
            }
        }
        
        public void Eliminar(Int32 Codigo)
        {
            Raiz = EliminarNodos(Raiz, Codigo);
        }
        private clsNodo EliminarNodos(clsNodo NodoActual, Int32 Codigo)
        {
            if (NodoActual == null)
            {
                return null;
            }
            if (Codigo < NodoActual.Codigo)
            {
                NodoActual.Izquierdo = EliminarNodos(NodoActual.Izquierdo, Codigo);
            }
            else if (Codigo > NodoActual.Codigo)
            {
                NodoActual.Derecho = EliminarNodos(NodoActual.Derecho, Codigo);
            }
            else
            {
                if (NodoActual.Izquierdo == null)
                {
                    return NodoActual.Derecho;
                }
                else if (NodoActual.Derecho == null)
                {
                    return NodoActual.Izquierdo;
                }

                clsNodo sucesor = NodoActual.Derecho;
                while (sucesor.Izquierdo != null)
                {
                    sucesor = sucesor.Izquierdo;
                }
                NodoActual.Codigo = sucesor.Codigo;
                NodoActual.Derecho = EliminarNodos(NodoActual.Derecho, sucesor.Codigo);
            }
            return NodoActual;
        }


        public bool Busqueda(Int32 Codigo)
        {
            clsNodo auxiliar = Raiz;
            while (auxiliar != null && auxiliar.Codigo != Codigo)
            {
                if (Codigo < auxiliar.Codigo)
                {
                    auxiliar = auxiliar.Izquierdo;
                }
                else
                {
                    auxiliar = auxiliar.Derecho;
                }
            }
            if (auxiliar != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public void Recorrer(ComboBox combo, bool ascedente, string recorrer)
        {
            combo.Items.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(combo, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(combo, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(combo, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(combo, Raiz);
            }
        }
        public void Recorrer(ListBox lst, bool ascedente, string recorrer)
        {
            lst.Items.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(lst, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(lst, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(lst, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(lst, Raiz);
            }
        }
       
        public void Recorrer(DataGridView Grilla, string recorrer, bool ascedente)
        {
            Grilla.Rows.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(Grilla, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(Grilla, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(Grilla, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(Grilla, Raiz);
            }
        }
    }
}