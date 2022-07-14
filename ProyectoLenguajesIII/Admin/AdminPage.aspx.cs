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

namespace ProyectoLenguajesIII.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        //SqlConnection conexion = new SqlConnection("database=Vaca Club (ProyectoLenguajesIII)");
        string con2 = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-ProyectoLenguajesIII-20220529080245.mdf;Initial Catalog=aspnet-ProyectoLenguajesIII-20220529080245;Integrated Security=True;";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProyectoLenguajesIII.mdf;Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["ProductAction"];
            if (productAction == "add")
            {
                LabelAddStatus.Text = "Producto añadido!";
            }

            if (productAction == "remove")
            {
                LabelRemoveStatus.Text = "Producto removido!";
            }

            //Desde aqui

            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProyectoLenguajesIII.mdf;Integrated Security=True;";
            
            
                if (!IsPostBack)
                {
                    this.SearchCustomers("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Estado from Orders  WHERE Estado='Pendiente'", tablatrans);
                    this.SearchCustomers("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Cadete,Estado from Orders  WHERE Estado = 'Aceptado'", tablatrans2);
                    this.SearchCustomers("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Cadete,Estado,FechaEnv from Orders  WHERE Estado = 'Entregado'", tablatransent);
                    this.SearchCustomers("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Cadete,Estado,FechaEnv from Orders  WHERE Estado = 'Enviado'", tablatransenv);
                    this.SearchCustomers("Vaca Club", "SELECT OrderId,OrderDate,Username,FirstName,LastName,Address,Phone,Email,TotalOrden,Preferences,tipoPago,Cadete,Estado,FechaEnv from Orders  WHERE Estado = 'Rechazado'", GridView1);

            }
            //Hasta aqui

            //using (SqlConnection sqlCon = new SqlConnection(connectionString))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT [OrderId], [OrderDate], [Username], [FirstName], [LastName], [Address], [Phone], [Email], [TotalOrden], [Preferences] from Orders", sqlCon);
            //    DataTable dtbl = new DataTable();
            //    sqlDa.Fill(dtbl);
            //    OrderItemList1.DataSource = dtbl;
            //    OrderItemList1.DataBind();
            //}

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT [OrderId], [ProductId], [Username], [Quantity], [UnitPrice], [ProductName], [Totalprod] from OrderDetails", sqlCon);
                DataTable dtbl2 = new DataTable();
                sqlDa2.Fill(dtbl2);
                OrderItemList2.DataSource = dtbl2;
                OrderItemList2.DataBind();
            }


            //string consulta = "select * from Orders";
            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            //DataTable dt = new DataTable();
            //adaptador.Fill(dt);
            //OrderItemList1.DataSource = dt;

            //SqlDataReader rdr = cmd.ExecuteReader();
            //List<Order> dt = new Order();
            //dt.Load(rdr);
            //OrderList.DataSource = dt;
            //OrderList.DataBind();
        }
        //Y desde aqui
        public void SearchCustomers(string conexion, string comando, GridView tabla)
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

        protected void Rechazar_Click(object sender, ImageClickEventArgs e)
        {
            string[] datos = ((sender as ImageButton).CommandArgument.Split(','));
            int id = Convert.ToInt32(datos[0]);
            string email = Convert.ToString(datos[1]);
            UpdateAceptarTabla("UPDATE Orders SET Estado='Rechazado', FechaEnv=GETDATE() WHERE OrderId = @id", id, email);
            this.Sendemail2(email);
            Response.Redirect("~/Admin/AdminPage.aspx");
        }

        protected void Aceptar_Click(object sender, ImageClickEventArgs e)
        {
            //DateTime ent = DateTime.Now;
            string[] datos = ((sender as ImageButton).CommandArgument.Split(','));
            int id = Convert.ToInt32(datos[0]);
            string email = Convert.ToString(datos[1]);
            UpdateAceptarTabla("UPDATE Orders SET Estado='Aceptado', Cadete='" + DropDownList1.SelectedValue + "', FechaEnv=GETDATE() WHERE OrderId = @id", id, email);
            //UpdateAceptarTabla("UPDATE Orders SET FechaEnv=ent WHERE OrderId = @id", id, email);
            Sendemail(email);
            Response.Redirect("~/Admin/AdminPage.aspx");
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

        public void UpdateAceptarTablaF(string coman, int id, string email)
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

        private void Sendemail(string txt1)
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

        private void Sendemail2(string txt1)
        {
            //int max = _db.Orders.Max(p => p.OrderId);
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("estoesparamiproy@outlook.com", "Vaca Club");
            mensaje.To.Add(txt1);
            mensaje.Subject = string.Format("Su pedido se rechazo.");

            mensaje.IsBodyHtml = false;
            mensaje.Body = "Su pedido fue rechazado. Contactenos aqui: estoesparamiproy@outlook.com para" +
                "consultar sobre el problemas ocurridos.";


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
        //Hasta aqui
        protected void AddProductButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Catalog/Images/");
            if (ProductImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    ProductImage.PostedFile.SaveAs(path + ProductImage.FileName);
                    // Save to Images/Thumbs folder.
                    ProductImage.PostedFile.SaveAs(path + "Thumbs/" + ProductImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                // Add product data to DB.
                AddProducts products = new AddProducts();
                bool addSuccess = products.AddProduct(AddProductName.Text, AddProductDescription.Text,
                    AddProductPrice.Text, DropDownAddCategory.SelectedValue, ProductImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "No se pudo añadir el producto a la base de datos.";
                }
            }
            else
            {
                LabelAddStatus.Text = "No se acepta el tipo de archivo.";
            }
        }

        public IQueryable GetCategories()
        {
            var _db = new ProyectoLenguajesIII.Models.ProductContext();
            IQueryable query = _db.Categories;
            return query;
        }

        public IQueryable GetProducts()
        {
            var _db = new ProyectoLenguajesIII.Models.ProductContext();
            IQueryable query = _db.Products;
            return query;
        }

        protected void RemoveProductButton_Click(object sender, EventArgs e)
        {
            using (var _db = new ProyectoLenguajesIII.Models.ProductContext())
            {
                int productId = Convert.ToInt16(DropDownRemoveProduct.SelectedValue);
                var myItem = (from c in _db.Products where c.ProductID == productId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Products.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "No se puede localizar el producto.";
                }
            }
        }

        protected void Btorddet_Click(object sender, EventArgs e)
        {
            OrderItemList2.Visible = true;
        }

        protected void Btorddet1_Click(object sender, EventArgs e)
        {
            OrderItemList2.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}