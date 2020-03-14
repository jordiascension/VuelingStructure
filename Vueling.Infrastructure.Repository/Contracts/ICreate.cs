using System;

namespace Vueling.Infrastructure.Repository.Contracts
{
    public interface ICreate<T>
    {
        T Create(T model);
    }
}
