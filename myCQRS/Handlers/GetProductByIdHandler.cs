using System;
using MediatR;
using myCQRS.DataStore;
using myCQRS.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace myCQRS.Handlers
{
    //handle request - Send(new GetProductByIdQuery())
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetProductByIdHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) =>
            await _fakeDataStore.GetProductById(request.Id);

    }
}

