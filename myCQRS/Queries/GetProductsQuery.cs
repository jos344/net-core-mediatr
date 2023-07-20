using System;
using MediatR;
using myCQRS.DataStore;
using System.Collections.Generic;

namespace myCQRS.Queries
{
    // This simply means our request will return a list of products.
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;

}

    


