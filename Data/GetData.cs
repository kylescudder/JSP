using JSP.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using JSP.Db;

namespace JSP.Data
{

    public class GetData : IGetData
    {
        private readonly ISqlDb _dataAccess;
        public GetData(ISqlDb dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<List<Paragraph>> GetParagraphs()
        {
            var recs = await _dataAccess.LoadData<Paragraph, dynamic>(
                "jaiscudder_jai.spGetParagraphs",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<Service>> GetServices()
        {
            var recs = await _dataAccess.LoadData<Service, dynamic>(
                "jaiscudder_jai.spGetServices",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<Testimonial>> GetTestimonials()
        {
            var recs = await _dataAccess.LoadData<Testimonial, dynamic>(
                "jaiscudder_jai.spGetTestimonials",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<ContactPoint>> GetContactPoints()
        {
            var recs = await _dataAccess.LoadData<ContactPoint, dynamic>(
                "jaiscudder_jai.spGetContactPoints",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<Gallery>> GetGallerys()
        {
            var recs = await _dataAccess.LoadData<Gallery, dynamic>(
                "jaiscudder_jai.spGetGallerys",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<GalleryView>> GetGalleryViews(int ID)
        {
            var recs = await _dataAccess.LoadData<GalleryView, dynamic>(
                "jaiscudder_jai.spGetGalleryViewList",
                new { ID} ,
                "Default");
            return recs;
        }
    }
}
