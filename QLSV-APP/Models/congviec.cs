using System.ComponentModel.DataAnnotations;

namespace WEBAPP.Models
{
    public class congviec
    {
        [Key]

        public int Id { get; set; }
        public string Post { get; set; }
        public string CompanyName { get; set; }
        public string place { get; set; }
        public string salaray { get; set; }
        public string jobType { get; set; }
        public string Shift { get; set; }
        public string Quali { get; set; }
        public string jobDetais { get; set; }
        public string rating { get; set; }
    }
}
//post: "Mechanical Supervisor",
//    companyName: "Vintage Coffee and Beverages Ltd",
//    place: "Telangana",
//    salaray: "240000",
//    jobType: ["Full-time", "Part-time", "Regular"],
//    Shift: "Day shift",
//    Quali: "Bachelor's (Required)",
//    jobDetais:
//"B Tech Mechanical with 3+ year experience in manufacturing and process industry.Responsible for total Maintenance of the Mechanical Dept. Able to handle Maintenance of Boiler, Pumps and motors, RO Plant, VAM, Compressors, DG Sets, Pumps, Blowers, rotating equipment ete.,Should also handle Fitters, welders, Instrumentation and Electricians.",
//    rating: "3.0",