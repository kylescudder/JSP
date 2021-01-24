using JSP.Data;
using JSP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSP.Pages
{
    public class ServicesModel : PageModel
    {
        private readonly ILogger<ServicesModel> _logger;
        private readonly IConfiguration _config;
        public ServicesModel(ILogger<ServicesModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        GetData d = new GetData();
        public List<ServiceList> Services { get; set; }
        public ActionResult OnGet()
        {
            string cs = _config.GetConnectionString("Default");
            Services = d.GetServices(cs);

            return Page();
        }
    }
}
