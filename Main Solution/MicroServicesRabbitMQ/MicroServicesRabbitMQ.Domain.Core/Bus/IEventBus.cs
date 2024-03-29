﻿using MicroServicesRabbitMQ.Domain.Core.Commands;
using MicroServicesRabbitMQ.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroServicesRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
