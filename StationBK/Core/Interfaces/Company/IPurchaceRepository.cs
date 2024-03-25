using StationBK.Core.Entities.company;

namespace StationBK.Core.Interfaces.Company
{
    public interface IPurchaceRepository
    {
        public Task AddPurchace(Purchace purchace);
        public Task<IEnumerable<Purchace>> GetPurchace();

    }
}
