using StationBK.Core.Entities.company;

namespace StationBK.Core.Interfaces.Company
{
    public interface IBalanceRepository
    {
        public Task<float> GetBalance(int mounth);
        public Task AddBalance(Balance balance);
    }
}
