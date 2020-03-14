

using System.Collections.Generic;

namespace Vueling.Application.Logic.Contracts
{
    public interface IGet<T>
    {
        List<T> GetAll();
    }
}
