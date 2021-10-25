using InterfaceSegragationPrinciple.Model;
using System;
using System.Collections.Generic;

namespace InterfaceSegragationPrinciple.Correct.Interfaces
{
    public interface IUserRepo
    {
        bool Add(User user);
        bool Update(User user);
        bool Remove(Guid id);
        User Get(Guid id);
        IEnumerable<User> GetAll();
        IEnumerable<User> Filter(Predicate<User> predicate);
    }
}
