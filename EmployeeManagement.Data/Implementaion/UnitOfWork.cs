using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;

namespace EmployeeManagement.Data.Implementaion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _ctx;

        public UnitOfWork(EmployeeManagementContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequest = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveType = new EmployeeLeaveTypeRepository(_ctx);
        }
        public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequest { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveType { get; private set; }

        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }    
    }
}
