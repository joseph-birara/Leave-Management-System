
using LeaveManagement.Domain.Common;
using System;

namespace LeaveManagement.Domain
{
    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType? LeaveType { get; set; } // No need for using Domain here
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string? RequestingEmployeeId { get; set; }

    }
}
