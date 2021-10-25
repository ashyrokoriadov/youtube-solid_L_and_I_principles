using InterfaceSegragationPrinciple.Correct.Interfaces;
using System;

namespace InterfaceSegragationPrinciple.Correct.Implementations
{
    public class DataManager : IDataManager
    {
        public void Refresh() => Console.WriteLine("Обновляю данные...");

        public void Save() => Console.WriteLine("Сохраняю данные...");
    }
}
