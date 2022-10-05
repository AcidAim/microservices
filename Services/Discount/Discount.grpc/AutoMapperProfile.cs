using AutoMapper;
using Discount.grpc.Entities;
using Discount.grpc.Protos;

namespace Discount.grpc;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CouponModel, Coupon>().ReverseMap();
    }
}