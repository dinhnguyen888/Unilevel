using System;
using System.Collections.Generic;

namespace Unilevel.DTOs
{
    public class ScheduleVisitCalendarDTO
    {
        public List<DateTime> ImplementationDates { get; set; }
        public string ImplementationTime { get; set; }
        public string VisitPurpose { get; set; }
        public List<string> VisitorIds { get; set; }
        public string DistributorId { get; set; }
    }
}
