using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.azure.servicebus.sender.Topics
{
    internal class TopicMessageSender : IDisposable
    {
        ITopicClient _topicClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="topicName"></param>
        public TopicMessageSender(string connectionString, string topicName)
        {
            _topicClient = new TopicClient(connectionString, topicName);
        }

        public async void Dispose()
        {
            if (_topicClient != null && !_topicClient.IsClosedOrClosing)
            {
                await _topicClient.CloseAsync();
            }
        }

        public async Task Send(string message)
        {
            Message servicebusMessage = new Message(Encoding.UTF8.GetBytes(message));

            await _topicClient.SendAsync(servicebusMessage);
        }
    }
}
