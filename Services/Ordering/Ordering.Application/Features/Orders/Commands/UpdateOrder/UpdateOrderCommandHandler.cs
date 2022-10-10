using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.Contracts.Persistence;
using Ordering.Application.Exceptions;
using Ordering.Application.Mapping;
using Ordering.Domain.Entities;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder;

public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<UpdateOrderCommandHandler> _logger;

    public UpdateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, ILogger<UpdateOrderCommandHandler> logger)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        var updatingOrder = await _orderRepository.GetByIdAsync(request.Id);
        if (updatingOrder == null) 
        {
            throw new NotFoundException(nameof(Order), request.Id);
        }

        updatingOrder = OrderMapper.UpdateCommandToOrder(request);

        await _orderRepository.UpdateAsync(updatingOrder);
        _logger.LogInformation("Order {UpdatingOrderId} has been updated", updatingOrder.Id);
        return Unit.Value;
    }
}