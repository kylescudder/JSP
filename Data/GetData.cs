using JSP.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSP.Data
{
    public class GetData
    {
        public List<ParagraphList> GetParagraphs(string cs)
        {

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "CALL spGetParagraphs";
            using var cmd = new MySqlCommand(sql, con);
            IList<ParagraphList> wsl = new List<ParagraphList>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ws = new ParagraphList();
                ws.ParagraphID = reader.GetInt32("ParagraphID");
                ws.Header = reader.GetString("Header");
                ws.Body = reader.GetString("Body");
                wsl.Add(ws);
            }
            reader.Close();
            return (List<ParagraphList>)wsl;
        }
        public List<ServiceList> GetServices(string cs)
        {

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "CALL spGetServices";
            using var cmd = new MySqlCommand(sql, con);
            IList<ServiceList> wsl = new List<ServiceList>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ws = new ServiceList();
                ws.ServiceID = reader.GetInt32("ServiceID");
                ws.Header = reader.GetString("Header");
                ws.Body = reader.GetString("Body");
                ws.ImageLocation = reader.GetString("ImageLocation");
                wsl.Add(ws);
            }
            reader.Close();
            return (List<ServiceList>)wsl;
        }
        public List<TestimonialList> GetTestimonials(string cs)
        {

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "CALL spGetTestimonials";
            using var cmd = new MySqlCommand(sql, con);
            IList<TestimonialList> wsl = new List<TestimonialList>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ws = new TestimonialList();
                ws.TestimonialID = reader.GetInt32("TestimonialID");
                ws.Testimonial = reader.GetString("Testimonial");
                ws.Who = reader.GetString("Who");
                wsl.Add(ws);
            }
            reader.Close();
            return (List<TestimonialList>)wsl;
        }
        public List<ContactPointList> GetContactPoints(string cs)
        {

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "CALL spGetContactPoints";
            using var cmd = new MySqlCommand(sql, con);
            IList<ContactPointList> wsl = new List<ContactPointList>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ws = new ContactPointList();
                ws.ContactPointID = reader.GetInt32("ContactPointID");
                ws.ContactPointType = reader.GetString("ContactPointType");
                ws.ContactPoint = reader.GetString("ContactPoint");
                wsl.Add(ws);
            }
            reader.Close();
            return (List<ContactPointList>)wsl;
        }
    }
}
