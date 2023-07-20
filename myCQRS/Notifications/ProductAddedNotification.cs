using System;
using MediatR;
using myCQRS.DataStore;

namespace myCQRS.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}

