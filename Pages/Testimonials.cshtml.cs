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
    public class TestimonialsModel : PageModel
    {
        private readonly ILogger<TestimonialsModel> _logger;
        private readonly IConfiguration _config;
        private readonly IGetData _getData;
        public TestimonialsModel(ILogger<TestimonialsModel> logger, IConfiguration config, IGetData getData)
        {
            _logger = logger;
            _config = config;
            _getData = getData;
        }
        public List<TestimonialList> Testimonials { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Testimonials = await _getData.GetTestimonials();

            return Page();
        }
    }
}
