using JSP.Model;
using JSP.Data;
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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _config;
        public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        GetData d = new GetData();
        public List<ParagraphList> Paragraphs { get; set; }
        public ActionResult OnGet()
        {
            string cs = _config.GetConnectionString("Default");
            Paragraphs = d.GetParagraphs(cs);

            return Page();

        }
    }
}
