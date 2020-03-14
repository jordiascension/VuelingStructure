

using System.Collections.Generic;

namespace Vueling.Infrastructure.Repository.Contracts
{
    public interface IGet<T>
    {
        List<T> GetAll();
    }
}
