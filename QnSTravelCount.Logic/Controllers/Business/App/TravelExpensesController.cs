using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonBase.Extensions;
using QnSTravelCount.Adapters.Exceptions;
using QnSTravelCount.Contracts.Business.App;
using QnSTravelCount.Logic.Controllers.Persistence.App;
using QnSTravelCount.Logic.Entities.Business.App;
using QnSTravelCount.Logic.Entities.Persistence.App;

namespace QnSTravelCount.Logic.Controllers.Business.App
{
    partial class TravelExpensesController
    {
        private TravelController travelController;
        private ExpenseController expenseController;

        partial void Constructed()
        {
            travelController = new TravelController(this);
            expenseController = new ExpenseController(this);
        }
        public int MaxPageSize => travelController.MaxPageSize;

        public Task<int> CountAsync()
        {
            return travelController.CountAsync();
        }

        public Task<ITravelExpenses> CreateAsync()
        {
            return Task.Run<ITravelExpenses>(() => new TravelExpenses());
        }

        public async Task<ITravelExpenses> GetByIdAsync(int id)
        {
            var result = default(TravelExpenses);
            var travel = await travelController.GetByIdAsync(id);

            if (travel != null)
            {
                result = new TravelExpenses();
                result.Travel.CopyProperties(travel);
                foreach (var item in await expenseController.QueryAsync(e => e.TravelId == id))
                {
                    result.ExpenseEntities.Add(item);
                }
            }
            else
            {
                throw new LogicException(ErrorType.InvalidId, "Entity can't find!");
            }
            return result;
        }
        public Task<IEnumerable<ITravelExpenses>> GetAllAsync()
        {
            return Task.Run<IEnumerable<ITravelExpenses>>(async () =>
            {
                List<ITravelExpenses> result = new List<ITravelExpenses>();

                foreach (var item in (await travelController.GetAllAsync()).ToList())
                {
                    result.Add(await GetByIdAsync(item.Id));
                }
                return result;
            });
        }

        public Task<IEnumerable<ITravelExpenses>> GetPageListAsync(int pageIndex, int pageSize)
        {
            return Task.Run<IEnumerable<ITravelExpenses>>(async () =>
            {
                List<ITravelExpenses> result = new List<ITravelExpenses>();

                foreach (var item in (await travelController.GetPageListAsync(pageIndex, pageSize)).ToList())
                {
                    result.Add(await GetByIdAsync(item.Id));
                }
                return result;
            });
        }

        public Task<IEnumerable<ITravelExpenses>> QueryPageListAsync(string predicate, int pageIndex, int pageSize)
        {
            return Task.Run<IEnumerable<ITravelExpenses>>(async () =>
            {
                List<ITravelExpenses> result = new List<ITravelExpenses>();

                foreach (var item in (await travelController.QueryPageListAsync(predicate, pageIndex, pageSize)).ToList())
                {
                    result.Add(await GetByIdAsync(item.Id));
                }
                return result;
            });
        }

        public async Task<ITravelExpenses> InsertAsync(ITravelExpenses entity)
        {
            entity.CheckArgument(nameof(entity));
            entity.Travel.CheckArgument(nameof(entity.Travel));
            entity.Expenses.CheckArgument(nameof(entity.Expenses));

            var result = new TravelExpenses();

            result.TravelEntity.CopyProperties(entity.Travel);
            await travelController.InsertAsync(result.TravelEntity);
            foreach (var item in entity.Expenses)
            {
                var expense = new Expense();

                expense.Travel = result.TravelEntity;
                expense.CopyProperties(item);
                await expenseController.InsertAsync(expense);
                result.ExpenseEntities.Add(expense);
            }
            return result;
        }

        public async Task<ITravelExpenses> UpdateAsync(ITravelExpenses entity)
        {
            entity.CheckArgument(nameof(entity));
            entity.Travel.CheckArgument(nameof(entity.Travel));
            entity.Expenses.CheckArgument(nameof(entity.Expenses));

            //Delete all costs that are no longer included in the list.
            foreach (var item in await expenseController.QueryAsync(e => e.TravelId == entity.Travel.Id))
            {
                var tmpExpense = entity.Expenses.SingleOrDefault(i => i.Id == item.Id);

                if (tmpExpense == null)
                {
                    await expenseController.DeleteAsync(item.Id);
                }
            }

            var result = new TravelExpenses();
            var travel = await travelController.UpdateAsync(entity.Travel);

            result.TravelEntity.CopyProperties(travel);
            foreach (var item in entity.Expenses)
            {
                if (item.Id == 0)
                {
                    item.TravelId = entity.Travel.Id;
                    var insEntity = await expenseController.InsertAsync(item);

                    item.CopyProperties(insEntity);
                }
                else
                {
                    var updEntity = await expenseController.UpdateAsync(item);

                    item.CopyProperties(updEntity);
                }
            }
            return result;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            if (entity != null)
            {
                foreach (var item in entity.Expenses)
                {
                    await expenseController.DeleteAsync(item.Id);
                }
                await travelController.DeleteAsync(entity.Travel.Id);
            }
            else
            {
                throw new LogicException(ErrorType.InvalidId, "Entity can't find!");
            }
        }

        public Task SaveChangesAsync()
        {
            return Context.SaveAsync();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            travelController.Dispose();
            expenseController.Dispose();

            travelController = null;
            expenseController = null;
        }
    }
}
