using System;
using MediatR;
using myCQRS.DataStore;

namespace myCQRS.Commands
{
    // IRequest signature doesn’t have a type parameter. This is because we aren’t returning a value.
    public record AddProductCommand(Product Product) : IRequest;
}

