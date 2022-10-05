namespace Discount.grpc.Entities;

public class Coupon
{
    public int Id { get; set; }
    public string CouponName { get; set; } = null!;
    public int ValueInPercent { get; set; }
}