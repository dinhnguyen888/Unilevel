using System;
using System.Collections.Generic;
using Unilevel.Models;
namespace Unilevel.DTOs
{
    public class VisitCalendarDTO
    {
        public int Id { get; set; }

        public string CalendarCreatorId { get; set; }

        public ICollection<DateTime> ImplementationDates { get; set; } 

        public string ImplementationTime { get; set; } // "morning", "afternoon", "allDay"

        public string VisitPurpose { get; set; } 

        public ICollection<string> Visitors { get; set; } 

        public string DistributorId { get; set; }
        public string DistributorName { get; set; }
        public string? VisitCalendarStatus { get; set; } //  IsVisited, NotVisited, Abort
    }

   
}
