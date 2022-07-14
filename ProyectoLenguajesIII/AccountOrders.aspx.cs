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

namespace ProyectoLenguajesIII
{
    public partial class AccountOrders : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProyectoLenguajesIII.mdf;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.SearchUser("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Estado from Orders  WHERE Estado='Pendiente' and Username='" + Context.User.Identity.GetUserName()+"'", tabladesp);
                this.SearchUser("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Estado,FechaEnv from Orders  WHERE Estado='Aceptado' and Username='" + Context.User.Identity.GetUserName() + "'", GridView2);
                this.SearchUser("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Estado,FechaEnv from Orders  WHERE Estado='Rechazado' and Username='" + Context.User.Identity.GetUserName() + "'", GridView1);
                this.SearchUser("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Estado,FechaEnv from Orders  WHERE Estado='Enviado' and Username='" + Context.User.Identity.GetUserName()+"'", tablatransenv);
                this.SearchUser("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Estado,FechaEnv from Orders  WHERE Estado='Entregado' and Username='" + Context.User.Identity.GetUserName() + "'", tablatransent);


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    //SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT [OrderId], [ProductId], [Quantity], [UnitPrice], [ProductName], [Totalprod] from OrderDetails where  Estado!=Rechazado and Username='" + Context.User.Identity.GetUserName() + "'", sqlCon);
                    SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT [OrderId], [ProductId], [Username], [Quantity], [UnitPrice], [ProductName], [Totalprod] from OrderDetails where Username='" + Context.User.Identity.GetUserName() + "'", sqlCon);
                    DataTable dtbl2 = new DataTable();
                    sqlDa2.Fill(dtbl2);
                    OrderItemList2.DataSource = dtbl2;
                    OrderItemList2.DataBind();
                }
            }
        }

        public void SearchUser(string conexion, string comando, GridView tabla)
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

        
        protected void Btorddet_Click1(object sender, EventArgs e)
        {
            OrderItemList2.Visible = true;
        }

        protected void Btorddet1_Click(object sender, EventArgs e)
        {
            OrderItemList2.Visible = false;
        }
    }
    
}