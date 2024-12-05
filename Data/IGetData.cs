using JSP.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JSP.Data
{
    public interface IGetData
    {
        Task<List<ContactPoint>> GetContactPoints();
        Task<List<Gallery>> GetGallerys();
        Task<List<GalleryView>> GetGalleryViews(int ID);
        Task<List<Paragraph>> GetParagraphs();
        Task<List<Service>> GetServices();
        Task<List<Testimonial>> GetTestimonials();
    }
}
