using JSP.Model;
using JSP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JSP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _config;
        private readonly IGetData _getData;
        public IndexModel(ILogger<IndexModel> logger, IConfiguration config, IGetData getData)
        {
            _logger = logger;
            _config = config;
            _getData = getData;
        }
        public List<Paragraph> Paragraphs { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Paragraphs = await _getData.GetParagraphs();

            return Page();

        }
    }
}
