using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveTypeVM : BaseVM
    {
        [Required]
        public string Name { get; protected set; }
        public int DefaultDays { get; protected set; }
        public DateTime DateCreated { get; protected set; }

        public void SetEmployeeType(string name)
        {
            this.Name = name;

        }
    }
}
