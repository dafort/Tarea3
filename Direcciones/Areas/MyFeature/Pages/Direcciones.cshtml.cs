using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdventureWorksNS.Data;

namespace MyFeatures.Pages
{
    public class DireccionesModel : PageModel
    {
        private AdventureWorksDB db;
        public Address[]? Productos { get; set; } = null;

        public DireccionesModel(AdventureWorksDB injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "AdventureWorks - Direcciones";
            Direcciones = db.Address.OrderBy(p => p.AddressLine1).ToArray();
        }
    }
}
