using System.ComponentModel.DataAnnotations;

namespace ProyectoLenguajesIII.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string Username { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrice { get; set; }

        public string ProductName { get; set; }
        public double Totalprod { get; set; }       
    }
}