using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JSP.Data;
using JSP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace JSP.Pages
{
    public class GalleryViewModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IGetData _getData;
        public GalleryViewModel(IConfiguration config, IGetData getData)
        {
            _config = config;
            _getData = getData;
        }
        public List<GalleryView> GalleryViews { get; set; }
        public async Task<IActionResult> OnGet()
        {
            GalleryViews = await _getData.GetGalleryViews(Convert.ToInt16(HttpContext.Request.Query["Id"]));

            return Page();
        }
    }
}
