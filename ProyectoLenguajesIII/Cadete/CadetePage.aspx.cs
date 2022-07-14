using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoLenguajesIII.Models;
using ProyectoLenguajesIII.Logic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net.Mail;
using Microsoft.AspNet.Identity;

namespace ProyectoLenguajesIII.Cadete
{
    public partial class CadetePage : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProyectoLenguajesIII.mdf;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.SearchDesp("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Cadete,Estado,FechaEnv from Orders  WHERE Estado='Aceptado' and Cadete='" + Context.User.Identity.GetUserName() + "'", tabladesp);
                this.SearchDesp("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Cadete,Estado,FechaEnv from Orders  WHERE Estado = 'Enviado' and Cadete='" + Context.User.Identity.GetUserName() + "'", tablatransenv);
                this.SearchDesp("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Cadete,Estado,FechaEnv from Orders  WHERE Estado = 'Entregado' and Cadete='" + Context.User.Identity.GetUserName() + "'", tablatransent);

            }

            //using (SqlConnection sqlCon = new SqlConnection(connectionString))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT [OrderId], [ProductId], [Username], [Quantity], [UnitPrice], [ProductName], [Totalprod] from OrderDetails where Estado!=Rechazado and Cadete='" + Context.User.Identity.GetUserName() + "'", sqlCon);
            //    DataTable dtbl2 = new DataTable();
            //    sqlDa2.Fill(dtbl2);
            //    OrderItemList2.DataSource = dtbl2;
            //    OrderItemList2.DataBind();
            //}
        }

        public void SearchDesp(string conexion, string comando, GridView tabla)
        {
            string constr = ConfigurationManager.ConnectionStrings[conexion].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(comando, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        tabla.DataSource = dt;
                        tabla.DataBind();
                    }

                }
            }
        }

        protected void Aceptardesp_Click(object sender, ImageClickEventArgs e)
        {
            DateTime ent = DateTime.Now;
            string[] datos = ((sender as ImageButton).CommandArgument.Split(','));
            int id = Convert.ToInt32(datos[0]);
            string email = Convert.ToString(datos[1]);
            UpdateAceptarTabla("UPDATE Orders SET Estado='Enviado', FechaEnv=GETDATE() WHERE OrderId = @id", id, email);
            Sendemailcad(email);
            Response.Redirect("~/Cadete/CadetePage.aspx");
        }

        public void UpdateAceptarTabla(string coman, int id, string email)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = coman;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = sqlCon;
                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void Rechazardesp_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Entregar_Click(object sender, ImageClickEventArgs e)
        {
            DateTime ent = DateTime.Now;
            string[] datos = ((sender as ImageButton).CommandArgument.Split(','));
            int id = Convert.ToInt32(datos[0]);
            string email = Convert.ToString(datos[1]);
            UpdateAceptarTabla("UPDATE Orders SET Estado='Entregado', FechaEnv=GETDATE() WHERE OrderId = @id", id, email);
            //Sendemailcad(email);
            Response.Redirect("~/Cadete/CadetePage.aspx");
        }

        private void Sendemailcad(string txt1)
        {
            //int max = _db.Orders.Max(p => p.OrderId);
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("estoesparamiproy@outlook.com", "Vaca Club");
            mensaje.To.Add(txt1);
            mensaje.Subject = string.Format("Gracias por la compra");

            mensaje.IsBodyHtml = false;
            mensaje.Body = "Su pedido fue enviado.";


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.office365.com";
            System.Net.NetworkCredential credenciales = new System.Net.NetworkCredential();

            credenciales.UserName = "estoesparamiproy@outlook.com";
            credenciales.Password = "Estaesmpassword01";

            smtp.UseDefaultCredentials = true;
            smtp.Credentials = credenciales;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mensaje);
        }

        //protected void Btorddet_Click(object sender, EventArgs e)
        //{
        //    OrderItemList2.Visible = true;
        //}

        //protected void Btorddet1_Click(object sender, EventArgs e)
        //{
        //    OrderItemList2.Visible = false;
        //}
    }
}