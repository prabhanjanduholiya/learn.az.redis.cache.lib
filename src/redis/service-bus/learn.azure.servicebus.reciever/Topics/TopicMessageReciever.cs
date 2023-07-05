using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.azure.servicebus.reciever.Queues
{
    internal class TopicMessageReciever : IDisposable
    {
        private readonly ServiceBusClient _client;

        private readonly ServiceBusProcessor _processor;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="topicName"></param>
        public TopicMessageReciever(string connectionString, string topicName, string subscriptionName)
        {
            _client = new ServiceBusClient(connectionString);
            _processor = _client.CreateProcessor(topicName, subscriptionName);
            _processor.ProcessMessageAsync += _processor_ProcessMessageAsync;
            _processor.ProcessErrorAsync += _processor_ProcessErrorAsync;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private Task _processor_ProcessErrorAsync(ProcessErrorEventArgs arg)
        {
            throw new NotImplementedException();
        }

        private Task _processor_ProcessMessageAsync(ProcessMessageEventArgs arg)
        {
            throw new NotImplementedException();
        }
    }
}
