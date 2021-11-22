using AutoMapper;
using EmployeeManagement.Common.VModels;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Common.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            //virgülden öncekini gördüğünde virgülden sonrakine çevir.Tersi olduğunda da yap.
            CreateMap<EmployeeLeaveType, EmployeeLeaveTypeVM>().ReverseMap();
            CreateMap<EmployeeLeaveAllocation, EmployeeLeaveAllocationsVM>().ReverseMap();
            CreateMap<EmployeeLeaveRequest, EmployeeLeaveRequestVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
