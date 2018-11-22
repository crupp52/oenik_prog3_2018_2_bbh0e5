using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSharing.Data;
using VideoSharing.Repository;

namespace VideoSharing.Logic.Test
{
    class LogicCreatorsTests
    {
        Mock<IRepository<Creators>> mock;
        CreatorsLogic logic;

        [SetUp]
        public void Setup()
        {
            this.mock = new Mock<IRepository<Creators>>();
            List<Creators> list = new List<Creators>()
            {
                new Creators() { creator_id = 1, creator_name = "AVA JACKSON", creator_email = "AVA.JACKSON18@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1980-10-06"), creator_premium = 1 },
                new Creators() { creator_id = 4, creator_name = "ISOBEL HANSEN", creator_email = "ISOBEL.HANSEN75@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1975-03-13"), creator_premium = 0 },
                new Creators() { creator_id = 5, creator_name = "JOSE CHAPMAN", creator_email = "JOSE.CHAPMAN13@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1977-01-11"), creator_premium = 1 },
                new Creators() { creator_id = 6, creator_name = "LAURIE GEORGE", creator_email = "LAURIE.GEORGE14@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1977-07-13"), creator_premium = 1 },
                new Creators() { creator_id = 13, creator_name = "MARCUS FRANKLIN", creator_email = "MARCUS FRANKLIN@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1986-10-27"), creator_premium = 0 },
                new Creators() { creator_id = 15, creator_name = "SOFIA BISHOP", creator_email = "SOFIA.BISHOP21@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1987-07-16"), creator_premium = 0 }
            };

            this.mock.Setup(x => x.GetAll()).Returns(list.AsQueryable());

            this.logic = new CreatorsLogic(this.mock.Object);
        }

        [Test]
        public void EmptyRepository()
        {
            Mock<IRepository<Creators>> empty = new Mock<IRepository<Creators>>();
            empty.Setup(x => x.GetAll()).Returns(new List<Creators>().AsQueryable());

            CreatorsLogic l = new CreatorsLogic(empty.Object);

            Assert.That(l.GetAll().Count(), Is.Zero);
        }

        [Test]
        [Sequential]
        public void GetElementByName_ContaintTestString([Values("AVA JACKSON", "LAURIE GEORGE", "SOFIA BISHOP")] string name)
        {
            var q = this.logic.GetElementByName(name);

            foreach (var item in q)
            {
                Assert.That(item.creator_name.Contains(name));
            }
        }

        [Test]
        [Sequential]
        public void GetElementByIdAndItIsExists([Values(1, 4, 13, 15)] int id)
        {
            var q = this.logic.GetElementById(id).First();

            Assert.That(q, Is.Not.Null);
        }
    }
}
