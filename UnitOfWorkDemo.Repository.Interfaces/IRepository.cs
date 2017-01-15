using System;
using UnitOfWorkDemo.Domain;

namespace UnitOfWorkDemo.Repository.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : Entity<TId> where TId : struct, IDisposable
    {
        TEntity Get(TId id);

    }
}