using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoLenguajesIII.Models;
using System.Web.ModelBinding;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoLenguajesIII
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Page_Load1(object sender, EventArgs e)
        //{
        //    string search = SearchProductName.Text;
        //    if(search==)
        //}
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new ProyectoLenguajesIII.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new ProyectoLenguajesIII.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {

        }

        //public IQueryable<Product> SearchBtn_Click([QueryString("id")] int? categoryId)
        //{
        //    string val = SearchProductName.Text;
        //    var _db = new ProyectoLenguajesIII.Models.ProductContext();
        //    IQueryable<Product> query = _db.Products;
        //    if (val!=null)
        //    {


        //            query = query.Where(p => p.ProductName == val);

        //    }
        //    return query;
        //}


        //public IQueryable<Product> GetSearchProducts([QueryString("id")] int? categoryId)
        //{
        //    var _db = new ProyectoLenguajesIII.Models.ProductContext();
        //    IQueryable<Product> query = _db.Products;
        //    if (categoryId.HasValue && categoryId > 0)
        //    {
        //        query = query.Where(p => p.CategoryID == ProductName);
        //    }
        //    return query;
        //}


        //public IQueryable<Category> GetProducts()
        //{
        //    var _db = new ProyectoLenguajesIII.Models.ProductContext();
        //    IQueryable<Category> query = _db.Categories;
        //    return query;
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    productList.DataSource = this.PopulateDataGridView();
        //}

        //private void txtName_KeyUp(object sender, KeyEventArgs e)
        //{
        //    productList.DataSource = this.PopulateDataGridView();
        //}

        //private DataTable PopulateDataGridView()
        //{
        //    string query = "SELECT CustomerID, ContactName, Country FROM Customers";
        //    query += " WHERE CustomerID LIKE '%' + @SearchTerm + '%'";
        //    query += " OR ContactName LIKE '%' + @SearchTerm + '%'";
        //    query += " OR Country LIKE '%' + @SearchTerm + '%'";
        //    query += " OR @SearchTerm = ''";
        //    string constr = @"Data Source=.\SQL2017;Initial Catalog=Northwind;Integrated Security=true";
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@SearchTerm", SearchProductName.Text.Trim());
        //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //            {
        //                DataTable dt = new DataTable();
        //                sda.Fill(dt);
        //                return dt;
        //            }
        //        }
        //    }
        //}

    }
}