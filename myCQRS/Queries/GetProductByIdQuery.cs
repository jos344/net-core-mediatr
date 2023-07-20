using System;
using MediatR;
using myCQRS.DataStore;

namespace myCQRS.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}

