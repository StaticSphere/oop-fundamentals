using AutoMapper;
using SingleResponsibilityAfter.DataModels;
using SingleResponsibilityAfter.ViewModels;

namespace SingleResponsibilityAfter.Mapping
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderViewModel, Order>();
        }
    }
}