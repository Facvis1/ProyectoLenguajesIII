using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoLenguajesIII.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Entradas"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Regionales"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Minutas"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Guarniciones"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Parrilla"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Cortes de ternera"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Cortes de cerdo y pollo"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Achuras y embutidos"
                },
                new Category
                {
                    CategoryID = 9,
                    CategoryName = "Nuestros elaborados"
                },
                new Category
                {
                    CategoryID = 10,
                    CategoryName = "Pastas y salsas"
                },
                new Category
                {
                    CategoryID = 11,
                    CategoryName = "Tablas"
                },
                new Category
                {
                    CategoryID = 12,
                    CategoryName = "Postres"
                },
                new Category
                {
                    CategoryID = 13,
                    CategoryName = "Bebidas"
                },
                new Category
                {
                    CategoryID = 14,
                    CategoryName = "Cervezas"
                },
                new Category
                {
                    CategoryID = 15,
                    CategoryName = "Vinos"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Provoleta",
                    Description = "Es un queso de color blanco con tonalidad amarillento uniforme y de baja humedad, graso o semigraso, elaborado con leche de vaca acidificada por cultivo de bacterias lácticas, coagulada por cuajo de cabrito, cordero o enzimas específicas.",
                    ImagePath="Provoleta.jpg",
                    UnitPrice = 999,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Rabas a la Romana",
                    Description = "Anillas de calamar rebozado con una mezcla de huevo con harina y a la provenzal.",
                    ImagePath="Rabas a la Romana.jpg",
                    UnitPrice = 150,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Empanadas Salteñas",
                    Description = "Empanada de origen boliviano ,​ comido como una merienda jugosa y rellena con carne, pollo u otras carnes, huevo duro, especias, y otros ingredientes, cocida al horno..",
                    ImagePath="Empanadas Salteñas.jpg",
                    UnitPrice = 99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Matambre a la Pizza",
                    Description = "Se coloca una cobertura de tomate, condimentos y queso sobre la parte que no tiene la grasa.",
                    ImagePath="Matambre a la Pizza.jpg",
                    UnitPrice = 2399,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Papas Fritas",
                    Description = " papas que se preparan cortándose en forma de bastones y friéndolas en aceite caliente hasta que queden doradas, crujientes para luego retirarlas del aceite y luego sazonarlas con sal.",
                    ImagePath="Papas Fritas.jpg",
                    UnitPrice = 499,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Parrillada VACA CLUB",
                    Description = "Plato compuesto de carne de vaca , chorizo , morcilla , etc.",
                    ImagePath="Parrillada VACA CLUB.jpg",
                    UnitPrice = 4849,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "1/2 Tira de Asado",
                    Description = "Carne proveniente de la costilla, se corta el costillar de manera horizontal.",
                    ImagePath="Tira de Asado.jpg",
                    UnitPrice = 1449,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "1/2 de Pollo deshuesado",
                    Description = "Pechuga de pollo deshuesada aporreada y enrollada alrededor de un trozo de mantequilla de ajo sin sal fría, que se empana y se fríe u hornea.",
                    ImagePath="Pollo deshuesado.jpg",
                    UnitPrice = 999,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Mollejas",
                    Description = "Las mollejas son un corte de carne de casquería, es decir, vísceras y otras partes comestibles del animal.",
                    ImagePath="Mollejas.jpg",
                    UnitPrice = 1449,
                    CategoryID = 8
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Filet de Lomo VACA CLUB",
                    Description = "Consiste en un filete de lomo de ternera, queso, jamón, huevo frito, tomate, lechuga y aderezos varios como mostaza, o mayonesa entre dos panes de lomo y de forma rectangular.",
                    ImagePath="Filet de Lomo VACA CLUB.jpg",
                    UnitPrice = 1449,
                    CategoryID = 9
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Sorrentinos de jamón y muzzarella",
                    Description = "Pasta rellena, ",
                    ImagePath="Sorrentinos de jamón y muzzarella.jpg",
                    UnitPrice = 699,
                    CategoryID = 10
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Tabla de Lomo p/2 pers",
                    Description = "Tabla de lomo para consumo de 2 personas.",
                    ImagePath="Tabla de Lomo para 2 pers.jpg",
                    UnitPrice = 3199,
                    CategoryID = 11
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Budín de Pan",
                    Description = "Comida dulce hecha con pan duro desmenuzado después de remojarlo en leche y huevo batido.",
                    ImagePath="Budín de Pan.jpg",
                    UnitPrice = 549,
                    CategoryID = 12
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Agua sin gas",
                    Description = "Agua sin gas.",
                    ImagePath="Agua sin gas.jpg",
                    UnitPrice = 249,
                    CategoryID = 13
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Heineken",
                    Description = "Es una cerveza con 5,0 % alc. vol., elaborada por la cervecería neerlandesa Heineken International.",
                    ImagePath="Heineken.jpg",
                    UnitPrice = 799,
                    CategoryID = 14
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Don David",
                    Description = "Amarillo verdoso con burbujas finas y persistentes. Notas aromáticas a frutas tropicales, manzana y ananá combinadas con levaduras que recuerdan al pan tostado. Su sabor es fresco, aromático y delicado.",
                    ImagePath="Don David.jpg",
                    UnitPrice = 1099,
                    CategoryID = 15
                }
            };

            return products;
        }
    }
}