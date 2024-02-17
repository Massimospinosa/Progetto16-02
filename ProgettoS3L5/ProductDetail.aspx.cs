using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static eCommerceProgettoS3L5.Index;

namespace eCommerceProgettoS3L5
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                if (Request.QueryString["ProductId"] != null)
                {
                    string productId = Request.QueryString["ProductId"];                    

                    List<Index.Product> products = GetProducts();
                    Index.Product selectedProduct = products.FirstOrDefault(p => p.ProductID == productId);

                    if (selectedProduct != null)
                    {                        
                        ProductNameLabel.Text = selectedProduct.Name;
                        ProductImage.ImageUrl = selectedProduct.ImagePath;
                        ProductDescriptionLabel.Text = selectedProduct.Description;
                        ProductPriceLabel.Text = "Prezzo: " + selectedProduct.Price.ToString("C"); // Formatta il prezzo come valuta
                    }
                }
            }
        }

        
        private List<Index.Product> GetProducts()
        {
            List<Index.Product> products = new List<Index.Product>
            {
                        new Index.Product 
                        { 
                            ProductID = "1", 
                            ImagePath = ResolveUrl("~/Images/image1.jpg"), 
                            Name = "HyperX Alloy Tastiera Meccanica", 
                            Description = "HyperX Alloy Origins Core è una tastiera tenkeyless, ultra-compatta e robusta, che si caratterizza per gli switch meccanici HyperX personalizzati appositamente per offrire ai gamer il giusto mix di stile, prestazioni e affidabilità. I tasti presentano LED visibili da cui emanano una sorprendente illuminazione con una forza di attivazione e un intervallo operativo bilanciato perfettamente, per garantire reattività e precisione. Grazie al suo telaio in alluminio, Alloy Origins Core può assicurare stabilità e fermezza anche quando la pressione dei tasti si fa frenetica, mentre i piedini offrono tre diversi livelli di inclinazione. Il design compatto TKL offre più libertà di movimento al mouse, che spesso gode di uno spazio ristretto sulle scrivanie, mentre il cavo USB Type-C scollegabile la rende estremamente comoda da trasportare.", 
                            Price = 1000.00m },
                        new Index.Product 
                        { 
                            ProductID = "2", 
                            ImagePath = ResolveUrl("~/Images/image2.jpg"), 
                            Name = "Razer Huntsman V2 Gaming", 
                            Description = "Razer è una società tecnologica multinazionale singaporiano-americana che progetta, sviluppa e vende elettronica di consumo, servizi finanziari e hardware di gioco. Fondata da Min-Liang Tan e Robert Krakoff, ha due sedi a nord, Singapore e Irvine, California, Stati Uniti.La tastiera Razer Huntsman Tournament Edition con interruttori rossi è un capolavoro per gli appassionati di gaming. La risposta immediata degli interruttori rossi è un sogno per i giocatori che cercano prestazioni di alto livello. La tastiera compatta è perfetta per il gaming in movimento, e il design senza tastierino numerico ottimizza lo spazio senza compromettere la funzionalità.", 
                            Price = 900.00m },
                        new Index.Product 
                        { 
                            ProductID = "3", 
                            ImagePath = ResolveUrl("~/Images/image3.jpg"), 
                            Name = "Razer Huntman V2 Pro", 
                            Description = "Razer è una società tecnologica multinazionale singaporiano-americana che progetta, sviluppa e vende elettronica di consumo, servizi finanziari e hardware di gioco. Fondata da Min-Liang Tan e Robert Krakoff, ha due sedi a nord, Singapore e Irvine, California, Stati Uniti.Ti presentiamo la Razer DeathStalker V2 Pro—una tastiera ottica wireless ultra sottile ottimizzata per offrirti prestazioni e durabilità. Dotata dei nuovi switch a basso profilo e di Razer™ HyperSpeed Wireless per la massima responsività mentre giochi, in un telaio ultra sottile, ergonomico e resistente.Senza rinunciare alla responsività fulminea che contraddistingue tutte le nostre tastiere ottiche, digita più velocemente, grazie ai nuovissimi switch con un'altezza di attuazione minore e una corsa ridotta, con una durata fino a 70 milioni di battute per offrirti ottime prestazioni nel tempo.", 
                            Price = 950.00m },
                        new Index.Product 
                        {
                            ProductID = "4", 
                            ImagePath = ResolveUrl("~/Images/image4.jpg"), 
                            Name = "Razer Tenkeyless con poggiapolsi", 
                            Description = "Razer è una società tecnologica multinazionale singaporiano-americana che progetta, sviluppa e vende elettronica di consumo, servizi finanziari e hardware di gioco. Fondata da Min-Liang Tan e Robert Krakoff, ha due sedi a nord, Singapore e Irvine, California, Stati Uniti.La responsività, ultra sottile. Ti presentiamo la Razer Huntsman V2 TKL: una tastiera ottica tenkeyless da gaming con un'acustica migliorata, una latenza di input vicina a zero e altre caratteristiche di alta gamma per offrirti un fattore di forma compatto con prestazioni full size.Con una velocità fulminea di attuazione, accompagnata da una durata di fino a 100 milioni di battute, gli switch ottici Razer™ sono migliori dei tasti meccanici tradizionali, un vantaggio cruciale e indispensabile per gli esport.", 
                            Price = 50.00m },
                        new Index.Product 
                        { 
                            ProductID = "5", 
                            ImagePath = ResolveUrl("~/Images/image5.jpg"), 
                            Name = "Glorious Gaming GMMK Compact", 
                            Description = "La GMMK Compact (60%) è la tastiera modulare originale. Costruisci la tastiera dei tuoi sogni con i tuoi switch e i tuoi tasti, senza dover ricorrere alla saldatura.Con i suoi tasti sospesi, la GMMK dona alla scrivania un look davvero minimalista.Hai controllato le opzioni di personalizzazione delle tue tastiere? Ecco una veloce panoramica dei prodotti che noi di Glorious amiamo usare per personalizzare le nostre tastiere.Non sai da dove iniziare? Non preoccuparti, abbiamo scelto 5 dei nostri look preferiti, corredati da tutto ciò che serve per crearli. Rubaci le idee o crea i tuoi design.", 
                            Price = 200.00m },
                        new Index.Product 
                        { 
                            ProductID = "6", 
                            ImagePath = ResolveUrl("~/Images/image6.jpg"), 
                            Name = "Logotech G413", 
                            Description = "Un design eccezionale si integra con una semplicità ideale. La perfezione a portata di mano.Resistenza al calore e all’usura di massimo grado. Uno dei materiali più resistenti per la produzione delle coperture tasti.I LED bianchi consentono massima precisione e nitidezza grazie a un design che ti permette di continuare a giocare.G413 SE è dotato di una struttura in alluminio spazzolato nero per una flessione minima e una durata ottimale.La cuffia con microfono è perfetta in ogni momento della tua vita, per giocare, da solo o con gli amici, e riprodurre musica.", 
                            Price = 400.00m },
            };

            return products;
        }

        private void AddProductToCart(Product product)
        {
            List<Product> cart = Session["Cart"] as List<Product> ?? new List<Product>();

            cart.Add(product);

            Session["Cart"] = cart;
        }

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["ProductId"] != null)
            {
                string productId = Request.QueryString["ProductId"];

                List<Product> products = GetProducts(); 
                Product selectedProduct = products.FirstOrDefault(p => p.ProductID == productId);                

                if (selectedProduct != null)
                {
                    AddProductToCart(selectedProduct);
                    Response.Redirect(Request.RawUrl);
                }
            }
        }
    }
}