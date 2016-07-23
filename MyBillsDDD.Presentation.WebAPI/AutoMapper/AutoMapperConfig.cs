using AutoMapper;
using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Presentation.VM;

namespace MyBillsDDD.Presentation.WebAPI.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapper()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<BillVM, Bill>();
                x.CreateMap<Bill, BillVM>();
            });
        }
    }
}