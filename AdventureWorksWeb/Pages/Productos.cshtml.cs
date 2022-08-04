using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdventureWorksNS.Data;

namespace AdventureWorksWeb.Pages
{
    public class ProductosModel : PageModel
    {
        private AdventureWorksDB? db;
        public IEnumerable<Product> Productos { get; set; }

        [BindProperty]
        public Product? Producto { get; set; }

        public ProductosModel(AdventureWorksDB injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "AdventureWorks - Productos";
            Productos = db.Products.OrderBy(c => c.Name);
        }

        public IActionResult OnPost()
        {
            if (Producto is not null)
            {
                Producto.ProductCategoryID = "Temp";
                db.Products.Add(Producto);
                db.SaveChanges();
                return RedirectToAction("/Productos");
            }
            else
            {
                return Page();
            }
        }

    }
}