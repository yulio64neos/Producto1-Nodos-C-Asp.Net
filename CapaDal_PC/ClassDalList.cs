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
            //Declaro una variable de tipo arreglo string
            string[] result = new string[countNodes];
            //Creo un objeto temporal
            NodoLista r1 = null;
            //Creo una variable con inicializador desde 0
            int c = 0;
            //R1 se asigna con el ancla
            r1 = Ancla;
            //Si r1 es diferente de nulo, entonces avanza
            while(r1 != null)
            {
                result[c] = r1.info.ShowCells();
                c++;
                r1 = r1.sig;
            }
            //El resultado al mostrar la lista
            return result;
        }

        //Buscando el nodo
        public NodoLista Buscar(int cla)
        {
            NodoLista r1 = null;
            NodoLista piedrita = null;
            r1 = Ancla;
            while(r1 != null)
            {
                if(r1.info.clave == cla)
                {
                    piedrita = r1;
                }
                r1 = r1.sig;
            }
            return piedrita;
        }//Fin del método

        //Método para ubicar el anterior nodo
        public NodoLista AnteriorElement(int cla)
        {
            NodoLista r1 = null;
            NodoLista antes = null;
            NodoLista antesBuscado = null;

            r1 = Ancla;
            antes = r1;
            while(r1 != null)
            {
                if(r1.info.clave == cla)
                {
                    antesBuscado = antes;
                }
                antes = r1;

                //Esta 
                r1 = r1.sig;
            }
            return antesBuscado;
        }//Fin del método

        //Método para eliminar nodo
        public string deleteNode(int cla)
        {
            NodoLista encontrado = null;
            NodoLista anterior = null;
            string salida = "";
            encontrado = Buscar(cla);
            if(encontrado != null)
            {
                if(encontrado == Ancla)
                {
                    Ancla = encontrado.sig;
                    encontrado.sig = null;
                    salida = "Eliminando al 1er nodo juas jusa juas";
                }
                else
                {
                    anterior = AnteriorElement(cla);
                    anterior.sig = encontrado.sig;
                    encontrado.sig = null;
                    encontrado = null;
                    salida = "Eliminado correctamente NICE VERY NICE";
                }
            }
            else
            {
                salida = "No se puede eliminar algo que YA NO EXISTE KRNAL";
            }
            return salida;
        }//Fin del método
        


    }//Fin de la clase
}
