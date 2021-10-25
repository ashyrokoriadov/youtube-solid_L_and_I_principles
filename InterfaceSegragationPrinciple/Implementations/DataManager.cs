using InterfaceSegragationPrinciple.Model;
using System;
using System.Collections.Generic;

namespace InterfaceSegragationPrinciple.Implementations
{
    public class DataManager : IConnector
    {
        public bool Add(User user) => false;

        public IEnumerable<User> Filter(Predicate<User> predicate) => throw new NotImplementedException();

        public User Get(Guid id) => throw new NotImplementedException();

        public IEnumerable<User> GetAll() => throw new NotImplementedException();

        public bool Remove(Guid id) => false;

        public bool Update(User user) => false;

        public Connection GetConnection() => throw new NotImplementedException();

        public void DisposeConnection() { }

        public void Refresh() => Console.WriteLine("Обновляю данные...");

        public void Save() => Console.WriteLine("Сохраняю данные...");
    }
}
