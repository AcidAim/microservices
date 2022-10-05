using Dapper;
using Discount.grpc.Entities;
using Npgsql;

namespace Discount.grpc.Repositories;

public class DiscountRepository : IDiscountRepository
{
    private readonly IConfiguration _configuration;

    public DiscountRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<Coupon> GetDiscount(string couponName)
    {
        await using var connection = new NpgsqlConnection(_configuration["DatabaseSettings:ConnectionString"]);
        var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>(
            @"SELECT * FROM ""Coupon"" WHERE ""CouponName"" = @CouponName",
            new {CouponName = couponName});
        return coupon;
    }

    public async Task<bool> CreateDiscount(Coupon coupon)
    {
        await using var connection = new NpgsqlConnection(_configuration["DatabaseSettings:ConnectionString"]);
        var affected = await connection.ExecuteAsync(
            @"INSERT INTO ""Coupon"" (""CouponName"", ""ValueInPercent"") VALUES (@CouponName, @ValueInPercent)",
            new {  coupon.CouponName,  coupon.ValueInPercent });
        if (affected == 0)
        {
            return false;
        }

        return true;
    }

    public async Task<bool> UpdateDiscount(Coupon coupon)
    {
        await using var connection = new NpgsqlConnection(_configuration["DatabaseSettings:ConnectionString"]);

        var affected = await connection.ExecuteAsync(
            @"UPDATE ""Coupon"" SET ""CouponName"" = @CouponName, ""ValueInPercent"" = @ValueInPercent WHERE ""Id"" = @Id",
            new { coupon.CouponName, coupon.ValueInPercent, coupon.Id });
        if (affected == 0)
        {
            return false;
        }

        return true;
    }

    public async Task<bool> DeleteDiscount(string couponName)
    {
        await using var connection = new NpgsqlConnection(_configuration["DatabaseSettings:ConnectionString"]);

        var affected = await connection.ExecuteAsync(@"DELETE FROM ""Coupon"" WHERE ""CouponName"" = @CouponName",
            new { CouponName = couponName });
        if (affected == 0)
        {
            return false;
        }

        return true;
    }
}