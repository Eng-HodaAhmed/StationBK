using StationBK.Core.Entities.company;

namespace StationBK.Core.Interfaces.Company
{
    public interface IDepositRepository
    {
        public Task AddDeposit(Deposit deposit);
        public Task<IEnumerable<Deposit>> GetDeposit();
    }
}
