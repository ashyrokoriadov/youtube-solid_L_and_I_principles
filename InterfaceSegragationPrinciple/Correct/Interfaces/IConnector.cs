namespace InterfaceSegragationPrinciple.Correct.Interfaces
{
    public interface IConnector : IDataManager, IConnectionHandler, IUserRepo
    {
    }
}
