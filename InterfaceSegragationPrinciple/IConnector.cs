using InterfaceSegragationPrinciple.Model;
using System;
using System.Collections.Generic;

namespace InterfaceSegragationPrinciple
{
    public interface IConnector
    {
        bool Add(User user);
        bool Update(User user);
        bool Remove(Guid id);
        User Get(Guid id);
        IEnumerable<User> GetAll();
        IEnumerable<User> Filter(Predicate<User> predicate);
        void Refresh();
        void Save();
        Connection GetConnection();
        void DisposeConnection();
        //еще пара десятков каких-то методов и других членов
    }
}
