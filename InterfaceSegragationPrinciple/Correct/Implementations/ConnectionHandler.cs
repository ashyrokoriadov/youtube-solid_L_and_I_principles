using InterfaceSegragationPrinciple.Correct.Interfaces;
using InterfaceSegragationPrinciple.Model;
using System;

namespace InterfaceSegragationPrinciple.Correct.Implementations
{
    public class ConnectionHandler : IConnectionHandler
    {
        public Connection GetConnection() => new Connection() { Id = Guid.NewGuid() };

        public void DisposeConnection() => Console.WriteLine("Освобождаю ресурсы соединения...");

        public void Send(string data) => Console.WriteLine("Отправляю данные по соединению...");
    }
}
