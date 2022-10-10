using Ordering.Application.Features.Orders.Commands.CheckoutOrder;
using Ordering.Application.Features.Orders.Commands.UpdateOrder;
using Ordering.Application.Features.Orders.Queries.GetOrdersList;
using Ordering.Domain.Entities;

namespace Ordering.Application.Mapping;
//Mapping Profiles on design-time to avoid automapper
public class OrderMapper
{
    public static OrderDto OrderToDto (Order order)
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

    public static Order DtoToOrder(OrderDto orderDto)
    {
        return new Order
        {
            UserName = orderDto.UserName,
            TotalPrice = orderDto.TotalPrice,
            FirstName = orderDto.FirstName,
            LastName = orderDto.LastName,
            EmailAddress = orderDto.EmailAddress,
            AddressLine = orderDto.AddressLine,
            Country = orderDto.Country,
            State = orderDto.State,
            ZipCode = orderDto.ZipCode,
            CardName = orderDto.CardName,
            CardNumber = orderDto.CardNumber,
            Expiration = orderDto.Expiration,
            CVV = orderDto.CVV,
            PaymentMethod = orderDto.PaymentMethod
        };
    }

    public static Order CheckoutCommandToOrder(CheckoutOrderCommand command)
    {
        return new Order
        {
            UserName = command.UserName,
            TotalPrice = command.TotalPrice,
            FirstName = command.FirstName,
            LastName = command.LastName,
            EmailAddress = command.EmailAddress,
            AddressLine = command.AddressLine,
            Country = command.Country,
            State = command.State,
            ZipCode = command.ZipCode,
            CardName = command.CardName,
            CardNumber = command.CardNumber,
            Expiration = command.Expiration,
            CVV = command.CVV,
            PaymentMethod = command.PaymentMethod
        };
    }

    public static CheckoutOrderCommand OrderToCheckoutCommand(Order order)
    {
        return new CheckoutOrderCommand
        {
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

    public static Order UpdateCommandToOrder (UpdateOrderCommand command)
    {
        return new Order
        {
            UserName = command.UserName,
            TotalPrice = command.TotalPrice,
            FirstName = command.FirstName,
            LastName = command.LastName,
            EmailAddress = command.EmailAddress,
            AddressLine = command.AddressLine,
            Country = command.Country,
            State = command.State,
            ZipCode = command.ZipCode,
            CardName = command.CardName,
            CardNumber = command.CardNumber,
            Expiration = command.Expiration,
            CVV = command.CVV,
            PaymentMethod = command.PaymentMethod
        };
    }

    public static UpdateOrderCommand OrderToUpdateCommand(Order order)
    {
        return new UpdateOrderCommand
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