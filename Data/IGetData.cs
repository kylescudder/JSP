using JSP.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JSP.Data
{
    public interface IGetData
    {
        Task<List<ContactPointList>> GetContactPoints();
        Task<List<GalleryList>> GetGallerys();
        Task<List<GalleryViewList>> GetGalleryViews(int ID);
        Task<List<ParagraphList>> GetParagraphs();
        Task<List<ServiceList>> GetServices();
        Task<List<TestimonialList>> GetTestimonials();
    }
}
