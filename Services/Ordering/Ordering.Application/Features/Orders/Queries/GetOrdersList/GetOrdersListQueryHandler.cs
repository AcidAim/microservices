using AutoMapper;
using MediatR;
using Ordering.Application.Contracts.Persistence;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList;

public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, List<OrderDto>>
{
    private readonly IOrderRepository _repository;
    private readonly IMapper _mapper;

    public GetOrdersListQueryHandler(IMapper mapper, IOrderRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<List<OrderDto>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
    {
        var orderList = await _repository.GetOrdersByUserName(request.UserName);
        return _mapper.Map<List<OrderDto>>(orderList);
    }
} 