using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace paginaWEBPRO
{
    public partial class Pagina1 : System.Web.UI.Page
    {

        protected OdbcConnection conectarBD()
        {
            try
            {
                OdbcConnection conexion = new OdbcConnection("Driver={SQL Server Native Client 11.0};Server=DESKTOP-31IUP7D;Uid=sa;Pwd=adminadmin;Database=baseServiciosItam;");
                conexion.Open();
                lbContador.Text = "conexion exitossa";
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



            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
               
                String query = String.Format("select contra from usuarios where nombreUsuario= '{0}'", txUsuario.Text, txContraseña.Text);
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                
                if (rd.HasRows)
                {
                    rd.Read();
                    Session["claveUnica"] = txUsuario.Text;
                    Response.Redirect("Agregar.aspx");
                    rd.Close();
                }
                else
                    lbContador.Text = "el ususario o contraseña son incorrectos";
            }


        }
    }
}