using System.Collections.Generic;
using System.Threading.Tasks;
using JSP.Data;
using JSP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace JSP.Pages
{
    public class GalleryModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IGetData _getData;
        public GalleryModel(IConfiguration config, IGetData getData)
        {
            _config = config;
            _getData = getData;
        }
        public List<Gallery> Gallerys { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Gallerys = await _getData.GetGallerys();

            return Page();
        }
    }
}
