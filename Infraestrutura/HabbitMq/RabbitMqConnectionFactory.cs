using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesafioMircroservicosInfraestrutura.HabbitMq
{
    public static class RabbitMqConnectionFactory
    {
        public static IConnection GetConnection(string hostName = "localhost")
        {
            var factory = new ConnectionFactory() { HostName = hostName };
            return (IConnection)factory.CreateConnectionAsync(); 
        }
    }
}
