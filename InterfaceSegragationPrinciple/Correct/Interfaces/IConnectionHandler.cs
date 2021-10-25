using InterfaceSegragationPrinciple.Model;

namespace InterfaceSegragationPrinciple.Correct.Interfaces
{
    public interface IConnectionHandler
    {
        Connection GetConnection();
        void DisposeConnection();
        void Send(string data);
    }
}
