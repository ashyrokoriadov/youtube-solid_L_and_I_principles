using InterfaceSegragationPrinciple.Correct.Interfaces;
using InterfaceSegragationPrinciple.Model;
using System;
using System.Collections.Generic;

namespace InterfaceSegragationPrinciple.Correct.Implementations
{
    public class UserRepo : IUserRepo
    {
        public bool Add(User user)
        {
            Console.WriteLine("Пользователь добавлен");
            return true;
        }

        public IEnumerable<User> Filter(Predicate<User> predicate)
        {
            Console.WriteLine("Получа пользователей по фильтру...");
            return new List<User>();
        }

        public User Get(Guid id)
        {
            Console.WriteLine("Пользователь получен");
            return new User();
        }

        public IEnumerable<User> GetAll()
        {
            Console.WriteLine("Получаю всех пользователей...");
            return new List<User>();
        }

        public bool Remove(Guid id)
        {
            Console.WriteLine("Пользователь удалён");
            return true;
        }

        public bool Update(User user)
        {
            Console.WriteLine("Пользователь изменен");
            return true;
        }
    }
}
