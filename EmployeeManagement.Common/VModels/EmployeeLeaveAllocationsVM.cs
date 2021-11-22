using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveAllocationsVM : BaseVM
    {
        public int NumberOfDays { get; set; }
        public int DateCreated { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; }
        public EmployeeVM EmployeeVm { get; set; }
        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm { get; set; }
    }
    
}
