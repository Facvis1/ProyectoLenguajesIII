using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLenguajesIII.Checkout
{
    public partial class CheckoutComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                // Clear shopping cart.
                using (ProyectoLenguajesIII.Logic.ShoppingCartActions usersShoppingCart =
                    new ProyectoLenguajesIII.Logic.ShoppingCartActions())
                {
                    usersShoppingCart.EmptyCart();
                }
            }
        }
    }
}