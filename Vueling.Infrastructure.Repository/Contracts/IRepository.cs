namespace Vueling.Infrastructure.Repository.Contracts
{
    public interface IRepository<T> : ICreate<T>,
                                      IUpdate<T>,
                                      IDelete,
                                      IGet<T>
    {
    }
}
