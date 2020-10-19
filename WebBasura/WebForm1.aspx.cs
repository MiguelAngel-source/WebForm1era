using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WebBasura
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCrossPagePostBack)
            {
                Literal1.Text = "Hola, Subscribete por favor";
            }
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root; password=talmud01");
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string valorNom = TextBoxNom.Text;
            string valorApp = TextBoxApp.Text;
            Literal1.Text = "Hola " + valorNom + " " + valorApp + " Te has subscrito";

            DateTime tempDate = DateTime.Now;
            string Fecha = (tempDate.ToString("yyyy-MM-dd"));
            //string Fecha2 = txtDate.Text;           

            //DateTime sdate = DateTime.ParseExact(txtDate.Text, "d", null);
            var fecha2 = txtDate.Text;

            double Dia;
            if (CheckBox1.Checked == true)
            {
                Dia = 0.5;
                
            }
            else
            {
                Dia = 1;
            }
            
            
            //fecha2 = Convert.ToDateTime(txtDate.Text);
            string inserQuery = "INSERT INTO refrigerador.nombreapellido(Nombre, Apellido, Fecha, FechReservar,DiaoMedio) VALUES('" + valorNom + "','" + valorApp + "','" + Fecha + "','" + fecha2 + "','" + Dia + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(inserQuery, connection);
            if (command.ExecuteNonQuery() == 1)
            {

            }
            connection.Close();

            //string Fecha2 = txtDate.Text;
            Literal2.Text = "Esta es la fecha escogida " + fecha2;

            TextBoxNom.Text = string.Empty;
            TextBoxApp.Text = string.Empty;
            txtDate.Text = string.Empty;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowData.aspx");
        }

 

        protected void txtDate_TextChanged(object sender, EventArgs e)
        {
            string fecha = txtDate.Text;
            Literal2.Text = "esta es la fecha escogida ";

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {   
        }
    }
}