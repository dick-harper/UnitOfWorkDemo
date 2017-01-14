using System;

namespace UnitOfWorkDemo.Domain
{
    public class Contact : Entity<int>
    {
        public virtual DateTime Created { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastNameName { get; set; }
        public virtual string MiddleName { get; set; }
    }
}