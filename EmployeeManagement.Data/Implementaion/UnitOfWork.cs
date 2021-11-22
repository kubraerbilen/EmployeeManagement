using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using System;

namespace EmployeeManagement.Data.Implementaion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _ctx;

        public UnitOfWork(EmployeeManagementContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_ctx);
        }
        public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; private set; }

        IEmployeeLeaveAllocationRepository IUnitOfWork.employeeLeaveAllocationRepository => throw new NotImplementedException();

        IEmployeeLeaveRequestRepository IUnitOfWork.employeeLeaveRequestRepository => throw new NotImplementedException();

        IEmployeeLeaveTypeRepository IUnitOfWork.employeeLeaveTypeRepository => throw new NotImplementedException();

        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

        void IUnitOfWork.Save()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
