namespace VideoSharing.Logic.Test
{
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    class LogicCategoriesTests
    {
        Mock<IRepository<Categories>> mock;
        CategoriesLogic logic;

        [SetUp]
        public void Setup()
        {
            this.mock = new Mock<IRepository<Categories>>();
            List<Categories> list = new List<Categories>()
            {
                new Categories() { category_id = 31, category_name = "FILM AND ANIMATION",category_adult = 0},
                new Categories() { category_id = 32, category_name = "COMEDY", category_adult = 0 },
                new Categories() { category_id = 33, category_name = "EDUCATION", category_adult = 0 },
                new Categories() { category_id = 34, category_name = "ENTERTAINMENT", category_adult = 0 },
                new Categories() { category_id = 37, category_name = "THRILLER", category_adult = 1 },
                new Categories() { category_id = 36, category_name = "GAMING", category_adult = 0 }
            };

            this.mock.Setup(x => x.GetAll()).Returns(list.AsQueryable());

            this.logic = new CategoriesLogic(this.mock.Object);
        }

        [Test]
        public void EmptyRepository()
        {
            Mock<IRepository<Categories>> empty = new Mock<IRepository<Categories>>();
            empty.Setup(x => x.GetAll()).Returns(new List<Categories>().AsQueryable());

            CategoriesLogic l = new CategoriesLogic(empty.Object);

            Assert.That(l.GetAll().Count(), Is.Zero);
        }

        [Test]
        [Sequential]
        public void GetElementByName_ContaintTestString([Values("FILM AND ANIMATION", "GAMING", "GAMING", "THRILLER")] string name)
        {
            var q = this.logic.GetElementByName(name);

            foreach (var item in q)
            {
                Assert.That(item.category_name.Contains(name));
            }
        }

        [Test]
        [Sequential]
        public void GetElementByIdAndItIsExists([Values(31, 32, 34, 36)] int id)
        {
            var q = this.logic.GetElementById(id).First();

            Assert.That(q, Is.Not.Null);
        }
    }
}
