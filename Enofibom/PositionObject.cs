using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom
{
    public class PositionObject
    {
        public int Id { get; set; }
        public string IMSI { get; set; }
        public string MSISDN { get; set; }
        public string CGI { get; set; }
        public string Kind { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Radius { get; set; }
        public string PlanName { get; set; }
        public Nullable<System.DateTime> locStamp { get; set; }
        public string AngleStart { get; set; }
        public string AngleEnd { get; set; }
        public string IMEI { get; set; }
        public Nullable<System.DateTime> eventStamp { get; set; }
        public string TAC { get; set; }
        public string CellName { get; set; }
        public Nullable<System.DateTime> RequestTime { get; set; }
        public string Presence { get; set; }
        public Nullable<System.DateTime> PresentFlag { get; set; }
        public Nullable<System.DateTime> DisappearedFlag { get; set; }
    }
}
