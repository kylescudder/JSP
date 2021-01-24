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
        public TestimonialsModel(ILogger<TestimonialsModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        GetData d = new GetData();
        public List<TestimonialList> Testimonials { get; set; }
        public ActionResult OnGet()
        {
            string cs = _config.GetConnectionString("Default");
            Testimonials = d.GetTestimonials(cs);

            return Page();
        }
    }
}
