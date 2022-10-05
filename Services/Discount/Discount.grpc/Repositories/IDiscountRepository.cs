using Discount.grpc.Entities;

namespace Discount.grpc.Repositories;

public interface IDiscountRepository
{
    Task<Coupon> GetDiscount(string couponName);
    Task<bool> CreateDiscount(Coupon coupon);
    Task<bool> UpdateDiscount(Coupon coupon);
    Task<bool> DeleteDiscount(string couponName);
}