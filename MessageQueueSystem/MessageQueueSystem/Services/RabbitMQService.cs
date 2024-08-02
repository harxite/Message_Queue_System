using RabbitMQ.Client;
using System.Text;

namespace MessageQueueSystem.Services
{
    public interface IMessageQueueService
    {
        void SendMessage(string message);
    }

    public class RabbitMQService : IMessageQueueService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;

        public RabbitMQService()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: "message_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);
        }

        public void SendMessage(string message)
        {
            var body = Encoding.UTF8.GetBytes(message);
            _channel.BasicPublish(exchange: "", routingKey: "message_queue", basicProperties: null, body: body);
        }
    }
}
