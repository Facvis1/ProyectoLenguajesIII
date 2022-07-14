using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoLenguajesIII.Logic;
using ProyectoLenguajesIII.Models;


namespace ProyectoLenguajesIII.Logic
{
    public class AddOrder
    {

        public bool AddOrders(DateTime orderdate, string nombre, string apellido, string direccion, string telefono,
            string email, string usernombre, string totalorden, string preferencias, DateTime orderenv, string cadete, string tipopago)
        {
            var myOrder = new Order();
            myOrder.OrderDate = orderdate;
            myOrder.Username = usernombre;
            myOrder.FirstName = nombre;
            myOrder.LastName = apellido;
            myOrder.Address = direccion;
            myOrder.City = "Ciudad de Salta";
            myOrder.State = "Salta";
            myOrder.PostalCode = "4401";
            myOrder.Country = "Argentina";
            myOrder.Phone = telefono;
            myOrder.Email = email;
            myOrder.Preferences = preferencias;
            myOrder.TotalOrden = totalorden;
            myOrder.Estado = "Pendiente";
            myOrder.FechaEnv = orderenv;
            myOrder.Cadete = cadete;
            myOrder.TipoPago = tipopago;


            using (ProductContext _db = new ProductContext())
            {
                // Add product to DB.
                _db.Orders.Add(myOrder);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }

        //public string GetOrderId()
        //{
        //    if (HttpContext.Current.Session[CartSessionKey] == null)
        //    {
        //        if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
        //        {
        //            HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
        //        }
        //        else
        //        {
        //            // Generate a new random GUID using System.Guid class.     
        //            Guid tempCartId = Guid.NewGuid();
        //            HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
        //        }
        //    }
        //    return HttpContext.Current.Session[CartSessionKey].ToString();
        //}
        //public List<Order> GetOrderItems()
        //{
        //    OrderId = GetOrderId();

        //    return _db.ShoppingCartItems.Where(
        //        c => c.CartId == ShoppingCartId).ToList();
        //}

    }

}