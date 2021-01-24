using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSP.Model
{
    public class ParagraphList
    {
        public int ParagraphID { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
    public class ServiceList
    {
        public int ServiceID { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string ImageLocation { get; set; }
    }
    public class TestimonialList
    {
        public int TestimonialID { get; set; }
        public string Testimonial { get; set; }
        public string Who { get; set; }
    }
    public class ContactPointList
    {
        public int ContactPointID { get; set; }
        public string ContactPointType { get; set; }
        public string ContactPoint { get; set; }
    }
}
