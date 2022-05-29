using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamaNodoPC
{
    public class NodoLista
    {
        public Computers info;
        public NodoLista sig = null;

        //Declaro 1er constructor de la clase
        public NodoLista(Computers objnew)
        {
            info = objnew;
            sig = null;
        }

        //Declaro 2do constructor de la clase
        //Posteriormente anexaré las imágenes
        public NodoLista(int cla, string cate, string marc, string mod, string ser, string descr)
        {
            //Construir un objeto mediante un JSON
            info = new Computers()
            {
                clave = cla,
                categoria = cate,
                marca = marc,
                modelo = mod,
                serie = ser,
                desc = descr
            };
        }
    }//Fin de la clase
}
