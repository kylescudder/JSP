using JSP.Model;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<ParagraphList>> GetParagraphs()
        {
            var recs = await _dataAccess.LoadData<ParagraphList, dynamic>(
                "jaiscudder_jai.spGetParagraphs",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<ServiceList>> GetServices()
        {
            var recs = await _dataAccess.LoadData<ServiceList, dynamic>(
                "jaiscudder_jai.spGetServices",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<TestimonialList>> GetTestimonials()
        {
            var recs = await _dataAccess.LoadData<TestimonialList, dynamic>(
                "jaiscudder_jai.spGetTestimonials",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<ContactPointList>> GetContactPoints()
        {
            var recs = await _dataAccess.LoadData<ContactPointList, dynamic>(
                "jaiscudder_jai.spGetContactPoints",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<GalleryList>> GetGallerys()
        {
            var recs = await _dataAccess.LoadData<GalleryList, dynamic>(
                "jaiscudder_jai.spGetGallerys",
                new { },
                "Default");
            return recs;
        }
        public async Task<List<GalleryViewList>> GetGalleryViews(int ID)
        {
            var recs = await _dataAccess.LoadData<GalleryViewList, dynamic>(
                "jaiscudder_jai.spGetGalleryViewList",
                new { ID} ,
                "Default");
            return recs;
        }
    }
}
