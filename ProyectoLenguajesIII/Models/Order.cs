using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProyectoLenguajesIII.Models
{
    public class Order
    {
        [ScaffoldColumn(true)]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string Username { get; set; }

        [Required(ErrorMessage = "Nombre requerido")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Apellido requerido")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Direccion requerida")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Ciudad requerida")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Provincia requerida")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Codigo postal requerido")]
        [DisplayName("Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Pais requerido")]
        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Direccion de Email requerida")]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "El Email no es valido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string PaymentTransactionId { get; set; }

        [ScaffoldColumn(false)]
        public bool HasBeenShipped { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public string TotalOrden { get; set; }

        [DisplayName("Preferencias de la orden")]
        [StringLength(160)]
        public string Preferences { get; set; }

        [Required(ErrorMessage = "Estado is required")]
        [StringLength(40)]
        public string Estado { get; set; }

        public DateTime FechaEnv { get; set; }

        public string Cadete { get; set; }

        public string TipoPago { get; set; }
    }
}