using System;
using NUnit.Framework;
using UnitOfWorkDemo.Domain;

namespace UnitOfWorkDemo.Repository.Tests.Integration
{
    [TestFixture]
    public class EntityTests : TestBase
    {
        [Test]
        public void Can_Get_Contact()
        {
            using (var session = this.SessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    var contact = new Contact
                    {
                        Created = DateTime.UtcNow,
                        DateOfBirth = DateTime.Parse("1992-4-23"),
                        FirstName = "Ted",
                        LastName = "Shred",
                        MiddleName = "Joe"
                    };

                    session.Save(contact);

                    Assert.IsTrue(contact.Id > 0);

                    var expectedId = contact.Id;

                    var result = session.Get(typeof(Contact), expectedId) as Contact;

                    Assert.IsNotNull(result);
                    Assert.AreEqual(expectedId, result.Id);
                }
            }
        }

        [SetUp]
        public void SetUp()
        {
            this.SessionFactory = TestBase.CreateSessionFactory();
        }

        [TearDown]
        public void TearDown()
        {
            this.SessionFactory = null;
        }
    }
}