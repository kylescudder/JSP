using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSP.Data;
using JSP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace JSP.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private readonly IConfiguration _config;
        public ContactModel(ILogger<ContactModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        GetData d = new GetData();
        public List<ContactPointList> ContactPoints { get; set; }
        public ActionResult OnGet()
        {
            string cs = _config.GetConnectionString("Default");
            ContactPoints = d.GetContactPoints(cs);

            return Page();
        }
    }
}
