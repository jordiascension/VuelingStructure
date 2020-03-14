﻿
namespace Vueling.Application.Logic.Contracts
{
    public interface IUpdate<T>
    {
        T Update(int id, T model);
    }
}
