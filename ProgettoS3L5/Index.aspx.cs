using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceProgettoS3L5
{
    public partial class Index : System.Web.UI.Page
    {
        public class Product
        {
            public string ProductID { get; set; }
            public string ImagePath { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        
            if (!IsPostBack)
            {
                LoadProductData();
            }
            
        }       

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            Button btnAddToCart = (Button)sender;
            string[] args = btnAddToCart.CommandArgument.Split('|');

            string productId = args[0];
            string productName = args[1];
            decimal productPrice = decimal.Parse(args[2]);
            
            Product selectedProduct = new Product
            {
                ProductID = productId,
                ImagePath = ResolveUrl("~/Images/" + productId + ".jpg"), 
                Name = productName,
                Description = "Breve descrizione dell'articolo " + productId,
                Price = productPrice
            };

            AddProductToCart(selectedProduct);
        }

        private void LoadProductData()
        {
            List<Product> products = new List<Product>
                      {
                new Product { ProductID = "1", ImagePath = ResolveUrl("~/Images/image1.jpg"), Name = "HyperX Alloy Tastiera Meccanica", Description = "Tastiera Meccanica", Price = 500.00m },
                new Product { ProductID = "2", ImagePath = ResolveUrl("~/Images/image2.jpg"), Name = "Razer Huntsman V2 Gaming", Description = "Perfetta per il Gaming", Price = 900.00m },
                new Product { ProductID = "3", ImagePath = ResolveUrl("~/Images/image3.jpg"), Name = "Razer Huntman V2 Pro", Description = "Adatta ad un uso professionale", Price = 750.00m },
                new Product { ProductID = "4", ImagePath = ResolveUrl("~/Images/image4.jpg"), Name = "Razer Tenkeyless con poggiapolsi", Description = "Adatta a chi passa molto tempo al PC!", Price = 450.00m },
                new Product { ProductID = "5", ImagePath = ResolveUrl("~/Images/image5.jpg"), Name = "Glorious Gaming GMMK Compact", Description = "Tastiera da Gaming economica", Price = 100.00m },
                new Product { ProductID = "6", ImagePath = ResolveUrl("~/Images/image6.jpg"), Name = "Logotech G413", Description = "Adatta a chi vuole approcciarsi al Gaming", Price = 300.00m },
               };

            ProductsRepeater.DataSource = products;
            ProductsRepeater.DataBind();
        }

        private void AddProductToCart(Product product)
        {            
            List<Product> cart = Session["Cart"] as List<Product> ?? new List<Product>();

            cart.Add(product);

            Session["Cart"] = cart;
        }

        protected void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            Button btnViewDetails = (Button)sender;
            string[] args = btnViewDetails.CommandArgument.Split('|');

            string productId = args[0];
            string productName = args[1];
            string productDescription = args[2];
            decimal productPrice = decimal.Parse(args[3]);
            string imagePath = args[4];

            Response.Redirect($"ProductDetail.aspx?ProductId={productId}&Name={productName}&Description={productDescription}&Price={productPrice}&ImagePath={imagePath}");
        }
    }
}