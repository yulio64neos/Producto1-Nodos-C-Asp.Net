using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importando el .dll del anteorior proyecto
using RamaNodoPC;

namespace CapaDal_PC
{
    //Esta representa la capa de acceso a datos DAL
    public class ClassDalList
    {
        //Referencia del objeto
        private NodoLista Ancla = null;
        //Declaración de contador de nodos privados
        private int countNodes = 0;

        public string Agregar(NodoLista nuevo)
        {
            string salida = "";
            //NodoLista será temporal
            NodoLista t = null;
            //Ancla al nuevo nodo
            if(Ancla == null)
            {
                Ancla = nuevo;
                salida = "Se insertó con exito el Nodo";
            }
            else
            {
                //La lista está vacía y hay que ubicarse en el ultimo nodo
                t = Ancla;
                while(t.sig != null)
                {
                    t = t.sig;
                }
                //Garantizo que t está en el último nodo
                t.sig = nuevo;
                salida = "Se insertó un nuevo nodo en la cola";
            }
            countNodes++;
            return salida;
        }//Fin del método

        public string[] MostrarList()
        {
            string[] result = new string[countNodes];
            NodoLista r1 = null;
            int c = 0;
            r1 = Ancla;
            while(r1 != null)
            {
                result[c] = r1.info.ShowCells();
                c++;
                r1 = r1.sig;
            }
            return result;
        }

    }//Fin de la clase
}
