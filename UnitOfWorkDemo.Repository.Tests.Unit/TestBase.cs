using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using UnitOfWorkDemo.Repository.NHIbernate.Mapping;

namespace UnitOfWorkDemo.Repository.Tests.Integration
{
    public class TestBase
    {
        protected ISessionFactory SessionFactory;

        protected static ISessionFactory CreateSessionFactory()
        {
            const string serverName = @"HARPER-WIN10\SQLEXPRESS";
            const string databaseName = "MvcDemo";

            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString($"Server={serverName};Database={databaseName};Trusted_Connection=True;"))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<ContactMapping>())
                .BuildSessionFactory();
        }
    }
}