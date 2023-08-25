using LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}