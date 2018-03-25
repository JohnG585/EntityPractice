using System.Threading.Tasks;

namespace EntityPractice.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EPDbContext context;
    
        public UnitOfWork(EPDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
