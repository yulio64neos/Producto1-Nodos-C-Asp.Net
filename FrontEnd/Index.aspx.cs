using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaBL_PC;

namespace FrontEnd
{
    public partial class Index : System.Web.UI.Page
    {
        //Creamos nuestro objeto de la clase ClassBL
        ClassBl bl = new ClassBl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["bl"] != null)
            {
                bl = (ClassBl)Session["bl"];
            }
        }

        protected void txtInsertar_Click(object sender, EventArgs e)
        {
            //Aquí llamo el método insertar PC, trayendo los parámetros del proyecto llamado RamaNodoPC
            bl.InsertPC(new RamaNodoPC.NodoLista(new RamaNodoPC.Computers()
            {
                clave = int.Parse(txtClave.Text),
                categoria = txtCate.Text,
                marca = txtMarca.Text,
                modelo = txtModel.Text,
                serie = txtSerie.Text,
                desc = txtDesc.Text
            }));
            Session["bl"] = bl;
        }

        //Muestro mis nodos
        protected void txtMostrar_Click(object sender, EventArgs e)
        {
            listNodos.Items.Clear();
            string[] arrePC = null;
            arrePC = bl.MostrarPC();
            foreach (string z in arrePC)
            {
                listNodos.Items.Add(z);
            }
        }
    }
}