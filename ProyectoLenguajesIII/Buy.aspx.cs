using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Linq;
using ProyectoLenguajesIII.Models;
using ProyectoLenguajesIII.Logic;

namespace ProyectoLenguajesIII
{
    public partial class Buy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Page_PreRender(object sender, EventArgs e)
        //{
        //    using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
        //    {
        //        string cartStr = string.Format("Carrito ({0})", usersShoppingCart.GetCount());
        //        cartCount.InnerText = cartStr;
        //    }
        //}
    }
}