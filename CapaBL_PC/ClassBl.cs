using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDal_PC;
using RamaNodoPC;

namespace CapaBL_PC
{
    public class ClassBl
    {
        //Se crea un objeto de la instancia ClassDalList
        private ClassDalList objDAL = new ClassDalList();
        //Se crea un método para invocar  la función Agregar desde la capa DAL
        public string InsertPC(NodoLista nuevo)
        {
            //Regreso invocando el método Agregar con el parámetro nuevo de tipo NODO
            return objDAL.Agregar(nuevo);
            //Recordemos que si vamos a agrgar un nuevo NODO, en sí, es todo el NODO, no un simple objeto
        }

        //Se crea un metodo que retorna un arreglo
        public string[] MostrarPC()
        {
            //Se invoca el método MostrarList sin necesidad de brindarle parámetros
            return objDAL.MostrarList();
        }
    }//Fin de la clase
}
