using JSP.Data;
using JSP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JSP.Pages
{
    public class ServicesModel : PageModel
    {
        private readonly ILogger<ServicesModel> _logger;
        private readonly IConfiguration _config;
        private readonly IGetData _getData;
        public ServicesModel(ILogger<ServicesModel> logger, IConfiguration config, IGetData getData)
        {
            _logger = logger;
            _config = config;
            _getData = getData;
        }
        public List<Service> Services { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Services = await _getData.GetServices();

            return Page();
        }
    }
}
