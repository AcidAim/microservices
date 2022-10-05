using Discount.grpc.Protos;

namespace Basket.api.GrpcServices;

public class DiscountGrpcService
{
    private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoServiceClient;

    public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoServiceClient)
    {
        _discountProtoServiceClient = discountProtoServiceClient;
    }

    public async Task<CouponModel> GetDiscount(string couponName)
    {
        var discountRequest = new GetDiscountRequest { CouponName = couponName };

        return await _discountProtoServiceClient.GetDiscountAsync(discountRequest);
    }
}