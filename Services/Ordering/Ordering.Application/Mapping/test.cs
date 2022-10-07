using Ordering.Application.Features.Orders.Queries.GetOrdersList;
using Ordering.Domain.Entities;

namespace Ordering.Application.Mapping;

public class OrderMapper
{
    public static OrderDto Map(Order order)
    {
        return new OrderDto
        {
            Id = order.Id,
            UserName = order.UserName,
            TotalPrice = order.TotalPrice,
            FirstName = order.FirstName,
            LastName = order.LastName,
            EmailAddress = order.EmailAddress,
            AddressLine = order.AddressLine,
            Country = order.Country,
            State = order.State,
            ZipCode = order.ZipCode,
            CardName = order.CardName,
            CardNumber = order.CardNumber,
            Expiration = order.Expiration,
            CVV = order.CVV,
            PaymentMethod = order.PaymentMethod
        };
    }
}