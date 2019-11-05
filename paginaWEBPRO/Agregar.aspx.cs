using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace paginaWEBPRO
{


    public partial class Agregar : System.Web.UI.Page
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
                    DropDownList1.Items.Clear();
                    while (rd.Read())
                    {
                        DropDownList1.Items.Add(rd.GetString(0));

                    }
                    rd.Close();

                    String query2 = String.Format("select nombre from materias");
                    OdbcCommand cmd2 = new OdbcCommand(query2, miConexion);
                    OdbcDataReader rd2 = cmd2.ExecuteReader();
                    DropDownList2.Items.Clear();
                    while (rd2.Read())
                    {
                        DropDownList2.Items.Add(rd2.GetString(0));

                    }
                    rd2.Close();

                    String query3 = String.Format("select nombre from docentes");
                    OdbcCommand cmd3 = new OdbcCommand(query3, miConexion);
                    OdbcDataReader rd3 = cmd3.ExecuteReader();
                    DropDownList3.Items.Clear();
                    while (rd3.Read())
                    {
                        DropDownList3.Items.Add(rd3.GetString(0));

                    }
                    rd3.Close();
                }

            }
        }
    

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

            try
            {
                //si se quiere agregar un servicio se instancian los elementos necesarios para la conexion 
                Int16 id = 0;// se pone el id provisionalmente en 0 para que no marque error 
                
                try
                {
                    OdbcConnection miConexion = conectarBD();
                    String query = String.Format("select max(servicios.idServicio) from servicios");//se encuentra el actual id servicio maximo para poner uno mayor
                    OdbcCommand cmd = new OdbcCommand(query, miConexion);
                    OdbcDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    id = Int16.Parse(rd[0].ToString());
                    id++;
                }
                catch (Exception ex)
                {
                    
                }

                String lugar = TextBox1.Text; // es posible dejar el lugar en blanco si asi se desea 
                String tipo = TextBox2.Text;
                String horaInicio = TextBox3.Text;
                String horaFin = TextBox4.Text;
                String curso;
                int idProf;
                // si se ingresa el servicio en los primeros 5 meses es que es de Primavera 
                if (int.Parse(DateTime.Now.Month.ToString()) < 6)
                {
                    curso = "Primavera";

                }
                else if (int.Parse(DateTime.Now.Month.ToString()) < 7)
                {
                    // antes del 7 es en verano 
                    curso = "Verano";

                }
                else
                {
                    // despues es en otoño 
                    curso = "Otoño";
                }
                // se pone el año actual 
                int año = int.Parse(DateTime.Now.Year.ToString());
                int idMateria = -1;
                // checa que alguna materia este seleccionada, el departamento es opcional para reducir la lista de materias 
                if (DropDownList1.SelectedIndex != -1)
                {

                    try
                    {
                        //se abre una conexion y se obtiene el id del nombre de la materia seleccionada 
                        OdbcConnection miConexion = conectarBD();
                        String query = String.Format("select materias.idMateria from materias where materias.nombre='{0}'", DropDownList1.SelectedItem.ToString());
                        OdbcCommand cmd = new OdbcCommand(query, miConexion);
                        OdbcDataReader rd = cmd.ExecuteReader();
                        rd.Read();
                        idMateria = int.Parse(rd[0].ToString());
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    idProf = int.Parse(DropDownList3.SelectedItem.ToString());
                    
                        

                        try
                        {
                        //abrir la conexión

                        OdbcConnection miConexion = conectarBD();

                        //command para ejecutar ek query (insert)
                        String query = String.Format(String.Format("insert into servicios (idServicio, lugar, tipo, horaInicio, horaFin, curso, año,idMateria,idDocente,dia) values ({0}, '{1}','{2}','{3}','{4}','{5}',{6},{7},{8},'{9}')",id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, idProf, dia);
                        OdbcCommand cmd = new OdbcCommand(query, miConexion);
                        id++;
                                                         //CERRAR CONEXIÓN
                            miConexion.Close();
                        }
                        catch (Exception ex)
                        {
                            
                        }

                        
                    
                    System.Media.SystemSounds.Asterisk.Play(); // se reproduce un sonidito 
                       
                        
                  
                }
                else
                {
                    
                }

            }
            catch (Exception ex)
            {
                
            }

        }


    }
}