using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom
{
    public class MobiObject
    {
        public string IMSI { get; set; }
        public string MSISDN { get; set; }
        public string CGI { get; set; }
        public string Kind { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string PlanName { get; set; }

        public string Radius { get; set; }
        public string AngleStart { get; set; }
        public string AngleEnd { get; set; }
    }

    public class Location 
    {
        
        public string CGI { get; set; }
        public string Kind { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string PlanName { get; set; }

        public string Radius { get; set; }
        public string AngleStart { get; set; }
        public string AngleEnd { get; set; }
    }
}
