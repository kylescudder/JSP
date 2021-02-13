using System.Collections.Generic;
using System.Threading.Tasks;
using JSP.Data;
using JSP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MailKit.Net.Smtp;
using MimeKit;

namespace JSP.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private readonly IConfiguration _config;
        private readonly IGetData _getData;
        public ContactModel(ILogger<ContactModel> logger, IConfiguration config, IGetData getData)
        {
            _logger = logger;
            _config = config;
            _getData = getData;
        }
        public List<ContactPointList> ContactPoints { get; set; }
        public ContactForm ContactForm { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ContactPoints = await _getData.GetContactPoints();

            return Page();
        }
        public ActionResult OnPostContact()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var Name = Request.Form["ContactForm.Name"].ToString();
            var Email = Request.Form["ContactForm.Email"].ToString();
            var PhoneNumber = Request.Form["ContactForm.PhoneNumber"].ToString();
            var Comment = Request.Form["ContactForm.Comment"].ToString();

            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress(Name,
            "mail@jaiscudderplumbing.co.uk");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",
            "mail@jaiscudderplumbing.co.uk");
            message.To.Add(to);

            message.Subject = Name;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<p>" + Name + " has contacted you.</p><br /><p>Their contact details are: " + Email +
                ", " + PhoneNumber + ".</p><br /><p>They have said: <br />" + Comment + "</p>";
            bodyBuilder.TextBody = Name + " has contacted you. Their contact details are: " + Email +
                ", " + PhoneNumber + ". They have said: " + Comment;
            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("in-v3.mailjet.com", 465, true);
            client.Authenticate("8337424b7df55e6b1a7221ed5422d0d7", "dea59603da0d055df9d03f48abc239f3");
            client.Send(message);
            client.Disconnect(true);
            client.Dispose();

            return RedirectToPage("./Index");
        }
    }
}
