
namespace Vueling.Infrastructure.Repository.Contracts
{
    public interface IUpdate<T>
    {
        T Update(int id, T model);
    }
}
