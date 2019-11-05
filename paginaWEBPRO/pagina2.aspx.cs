using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace paginaWEBPRO
{
    public partial class pagina2 : System.Web.UI.Page
    {

        protected OdbcConnection conectarBD()
        {
            try
            {
                OdbcConnection conexion = new OdbcConnection("Driver={SQL Server Native Client 11.0};Server=DESKTOP-31IUP7D;Uid=sa;Pwd=adminadmin;Database=baseServiciosItam;");
                conexion.Open();
                
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Materias.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profesores.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departamentos.aspx");
        }
    }
}