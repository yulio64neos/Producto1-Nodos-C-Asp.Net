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
    }
}