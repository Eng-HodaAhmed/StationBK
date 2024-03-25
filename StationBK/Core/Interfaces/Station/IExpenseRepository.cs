using StationBK.Core.Entities.Station;

namespace StationBK.Core.Interfaces.Station
{
    public interface IExpenseRepository
    {
        public Task AddExpense(List<Expense> expenseData);
        public Task<IEnumerable<Expense>> GetExpenses(int month,int year);
    }
}
