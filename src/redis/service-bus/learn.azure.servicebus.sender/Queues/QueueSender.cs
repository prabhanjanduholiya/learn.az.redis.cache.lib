using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.azure.servicebus.sender.Queues
{
    internal class QueueSender : IDisposable
    {
        IQueueClient _queueClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="queueName"></param>
        public QueueSender(string connectionString, string queueName)
        {
            _queueClient = new QueueClient(connectionString, queueName);
        }

        public async void Dispose()
        {
            if (_queueClient != null && !_queueClient.IsClosedOrClosing)
            {
                await _queueClient.CloseAsync();
            }
        }

        public async Task Send(string message)
        {
            Message servicebusMessage = new Message(Encoding.UTF8.GetBytes(message));

            await _queueClient.SendAsync(servicebusMessage);
        }
    }
}
