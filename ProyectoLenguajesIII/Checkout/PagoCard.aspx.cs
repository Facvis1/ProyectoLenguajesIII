using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoLenguajesIII.Logic;
using ProyectoLenguajesIII.Models;
using System.Data;
using System.Configuration;
using Microsoft.AspNet.Identity;

namespace ProyectoLenguajesIII.Checkout
{
    public partial class PagoCard : System.Web.UI.Page
    {
        private ProductContext _db = new ProductContext();

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProyectoLenguajesIII.mdf;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            int max = _db.Orders.Max(p => p.OrderId);

            lblTotalca.Text = Request.QueryString["total"];
            using (ProyectoLenguajesIII.Logic.ShoppingCartActions usersShoppingCart = new ProyectoLenguajesIII.Logic.ShoppingCartActions())
            {
                List<CartItem> myOrderList = usersShoppingCart.GetCartItems();

                // Add OrderDetail information to the DB for each product purchased.
                
                OrderItemList.DataSource = myOrderList;
                OrderItemList.DataBind();
            }
        }

        protected void cardbtn_Click(object sender, EventArgs e)
        {
            //AddCards cards = new AddCards();
            //AddOrder order = new AddOrder();
            //bool addSuccess1 = order.AddOrders(DateTime.Now, firstName.Text, lastName.Text, address.Text, phone.Text, email.Text, User.Identity.Name, preferencias.Text);
            //bool addSuccess = cards.AddCard(ccnumber.Text, Convert.ToInt32(cccvv.Text), ccexpiration.Text, ccname.Text);
            //int max = _db.Orders.Max(p => p.OrderId);

            //if (addSuccess & addSuccess1)
            //{
            //    // Reload the page.
            //    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
            //    this.sendemail(email.Text);
            //}
            //else
            //{
            //    lblcard.Text = "El pago ha sido cancelado!";
            //}
            //Response.Redirect("~/Checkout/CheckoutComplete.aspx?id=" + max);

            AddCards cards = new AddCards();
            AddOrder order = new AddOrder();
            bool addSuccess1 = order.AddOrders(DateTime.Now, firstName.Text, lastName.Text, address.Text, phone.Text, email.Text, User.Identity.Name, lblTotalca.Text, preferencias.Text, DateTime.Now,"","Tarjeta");
            bool addSuccess = cards.AddCard(ccnumber.Text, Convert.ToInt32(cccvv.Text), ccexpiration.Text, ccname.Text);
            //string[] datos = ((sender as ImageButton).CommandArgument.Split(','));
            //int id = Convert.ToInt32(datos[0]);
            //string email1 = Convert.ToString(datos[1]);
            //UpdateAceptarTabla("UPDATE Orders SET TipoPago='Tarjeta' WHERE OrderId = @id", id, email1);
            //SqlCommand query= SqlCommand()
            int max = _db.Orders.Max(p => p.OrderId);
            this.sendemail(email.Text);
            

            using (ProyectoLenguajesIII.Logic.ShoppingCartActions usersShoppingCart = new ProyectoLenguajesIII.Logic.ShoppingCartActions())
            {
                List<CartItem> myOrderList = usersShoppingCart.GetCartItems();

                // Add OrderDetail information to the DB for each product purchased.
                for (int i = 0; i < myOrderList.Count; i++)
                {
                    AddOrderDetails orderDetails = new AddOrderDetails();
                    orderDetails.AddOrdersDetails(max, myOrderList[i].ProductId, myOrderList[i].Product.ProductName, myOrderList[i].Quantity, Convert.ToDouble(myOrderList[i].Product.UnitPrice), Context.User.Identity.GetUserName());
                    


                }
                Response.Redirect("~/Checkout/CheckoutComplete.aspx?id=" + max);

            }
            if (addSuccess & addSuccess1)
            {

                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());



            }
            else
            {
                lblcard.Text = "El pago ha sido cancelado!";
            }
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

        private void sendemail(string txt1)
        {
            int max = _db.Orders.Max(p => p.OrderId);
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("estoesparamiproy@outlook.com", "Vaca Club");
            mensaje.To.Add(txt1);
            mensaje.Subject = string.Format("Gracias por su pedido");

            mensaje.IsBodyHtml = false;
            mensaje.Body = "Se ha realizado la orden correctamente. Ingresa a este link https://localhost:44309/AccountOrders " +
                "con tu cuenta y podras ver todas tus ordenes realizadas y sus estados. Puede contactarnos aqui: estoesparamiproy@outlook.com si hubo algun problema.";


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
    }
}