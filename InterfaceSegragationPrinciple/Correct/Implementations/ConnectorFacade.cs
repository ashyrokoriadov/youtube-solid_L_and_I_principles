using InterfaceSegragationPrinciple.Model;
using System;
using System.Collections.Generic;

namespace InterfaceSegragationPrinciple.Correct.Implementations
{
    public class ConnectorFacade : Interfaces.IConnector
    {
        private readonly Interfaces.IUserRepo _userRepo;
        private readonly Interfaces.IConnectionHandler _connectionHandler;
        private readonly Interfaces.IDataManager _dataManager;

        public ConnectorFacade(
            Interfaces.IUserRepo userRepo,
            Interfaces.IConnectionHandler connectionHandler,
            Interfaces.IDataManager dataManager
            )
        {
            _userRepo = userRepo;
            _connectionHandler = connectionHandler;
            _dataManager = dataManager;
        }

        public bool Add(User user) => _userRepo.Add(user);

        public void DisposeConnection() => _connectionHandler.DisposeConnection();

        public IEnumerable<User> Filter(Predicate<User> predicate) => _userRepo.Filter(predicate);

        public User Get(Guid id) => _userRepo.Get(id);

        public IEnumerable<User> GetAll() => _userRepo.GetAll();

        public Connection GetConnection() => _connectionHandler.GetConnection();

        public void Refresh() => _dataManager.Refresh();

        public bool Remove(Guid id) => _userRepo.Remove(id);

        public void Save() => _dataManager.Save();

        public void Send(string data) => _connectionHandler.Send(data);

        public bool Update(User user) => _userRepo.Update(user);
    }
}
