using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaBL_PC;
using System.Drawing;

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
            try
            {
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

                txtClave.Text = "";
                txtCate.Text = "";
                txtMarca.Text = "";
                txtModel.Text = "";
                txtSerie.Text = "";
                txtDesc.Text = "";
            }
            catch (Exception)
            {
                Response.Write("<script>Ingresa bien los datos</script>");
            }
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

        //Busco mis nodos de forma exitosa
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string salida = "";
            int claves = int.Parse(txtBusClav.Text);
            salida = bl.BuscarPC(claves);
            Response.Write("<script>alert('" + salida + "')</script>");
        }
        //Botón para eliminar 
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int cla = int.Parse(txtElimNodo.Text);
            bl.EliminarPC(cla);
            listNodos.Items.Clear();
        }
    }
}