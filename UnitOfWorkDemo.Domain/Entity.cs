
namespace UnitOfWorkDemo.Domain
{
    public abstract class Entity<TId>
    {
        public TId Id { get; set; }
    }
}