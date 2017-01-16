using System;
using NHibernate;

namespace UnitOfWorkDemo.Repository.NHIbernate
{
    public sealed class NHibernateSessionFactory
    {
        private static readonly Lazy<NHibernateSessionFactory> Lazy =
        new Lazy<NHibernateSessionFactory>(() => new NHibernateSessionFactory());

        public static NHibernateSessionFactory Instance => Lazy.Value;

        public ISession OpenSession()
        {
            return null;
        }

        private NHibernateSessionFactory()
        {
        }
    }
}