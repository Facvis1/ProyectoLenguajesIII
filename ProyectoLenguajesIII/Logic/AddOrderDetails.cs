using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoLenguajesIII.Models;

namespace ProyectoLenguajesIII.Logic
{
    public class AddOrderDetails
    {
        public bool AddOrdersDetails(int orderid, int productid, string productname, int cant, double precio, string username)
        {
            var myOrder = new OrderDetail();
            myOrder.OrderId = orderid;
            myOrder.ProductId = productid;
            myOrder.ProductName = productname;
            myOrder.Quantity = cant;
            myOrder.UnitPrice = precio;
            myOrder.Totalprod = cant * precio;
            myOrder.Username = username;

            using (ProductContext _db = new ProductContext())
            {
                // Add product to DB.
                _db.OrderDetails.Add(myOrder);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }

    }
}