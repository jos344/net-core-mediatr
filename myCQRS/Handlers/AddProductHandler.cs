using System;
using MediatR;
using myCQRS.Commands;
using myCQRS.DataStore;
using System.Threading;
using System.Threading.Tasks;

namespace myCQRS.Handlers
{
    // this class will handle the AddProductCommand request and return a void. 
    public class AddProductHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly FakeDataStore _fakeDataStore;

        public AddProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            // adding our value to our FakeDataStore.
            await _fakeDataStore.AddProduct(request.Product);

            return Unit.Value;
        }
    }
}

