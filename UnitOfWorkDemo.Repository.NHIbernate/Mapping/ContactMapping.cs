using FluentNHibernate.Mapping;
using UnitOfWorkDemo.Domain;

namespace UnitOfWorkDemo.Repository.NHIbernate.Mapping
{
    public class ContactMapping : ClassMap<Contact>
    {
        public ContactMapping()
        {
            Table("Contacts");
            Id(x => x.Id);
            Map(x => x.Created);
            Map(x => x.DateOfBirth);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.MiddleName);
        }
    }
}