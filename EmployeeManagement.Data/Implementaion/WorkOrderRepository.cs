using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.Implementaion
{
    public class WorkOrderRepository : Repository<WorkOrder>, IWorkOrderRepository
    {
        private readonly EmployeeManagementContext _ctx;

        public WorkOrderRepository(EmployeeManagementContext ctx) 
            :base(ctx)
        {
            _ctx = ctx;
        }
    }
}
