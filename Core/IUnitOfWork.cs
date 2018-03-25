using System.Threading.Tasks;

namespace EntityPractice.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}