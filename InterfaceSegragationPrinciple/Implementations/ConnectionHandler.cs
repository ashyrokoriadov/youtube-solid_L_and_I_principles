using InterfaceSegragationPrinciple.Model;
using System;
using System.Collections.Generic;

namespace InterfaceSegragationPrinciple.Implementations
{
    public class ConnectionHandler : IConnector
    {
        public bool Add(User user) => false;

        public IEnumerable<User> Filter(Predicate<User> predicate) => throw new NotImplementedException();

        public User Get(Guid id) => throw new NotImplementedException();

        public IEnumerable<User> GetAll() => throw new NotImplementedException();

        public bool Remove(Guid id) => false;

        public bool Update(User user) => false;

        public Connection GetConnection() => new Connection() { Id = Guid.NewGuid()};

        public void DisposeConnection() => Console.WriteLine("Освобождаю ресурсы соединения...");

        public void Refresh() { }


        public void Save() { }
    }
}
