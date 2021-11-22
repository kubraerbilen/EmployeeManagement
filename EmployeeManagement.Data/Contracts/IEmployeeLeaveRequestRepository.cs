﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.Contracts
{
    public interface IEmployeeLeaveRequestRepository : IRepositoryBase<EmployeeLeaveRequest>
    {
    }
}
