using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace paginaWEBPRO
{
    public partial class Departamentos : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                OdbcConnection miConexion = conectarBD();
                if (miConexion != null)
                {

                    String query = String.Format("select nombre from departamentos");
                    OdbcCommand cmd = new OdbcCommand(query, miConexion);
                    OdbcDataReader rd = cmd.ExecuteReader();
                    ListBox1.Items.Clear();
                    while (rd.Read())
                    {
                        ListBox1.Items.Add(rd.GetString(0));

                    }
                    rd.Close();

                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {

                String query2 = String.Format("select * from materias where idDepartamento = (select departamentos.idDepartamento from departamentos where departamentos.nombre='{0}') ", ListBox1.SelectedValue);
                OdbcCommand cmd2 = new OdbcCommand(query2, miConexion);
                OdbcDataReader rd2 = cmd2.ExecuteReader();
                tabla.DataSource = rd2;
                tabla.DataBind();
                rd2.Close();

            }
        }
    

    protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profesores.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Materias.aspx");
        }
    }
}