// <copyright file="LogicCategoriesTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Moq;
    using NUnit.Framework;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    /// <summary>
    /// CategoriesLogic test methods.
    /// </summary>
    [TestFixture]
    public class LogicCategoriesTests
    {
        private Mock<IRepository<Categories>> mock;
        private CategoriesLogic logic;

        /// <summary>
        /// Creates the mocked repository, and fills it up.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.mock = new Mock<IRepository<Categories>>();
            List<Categories> list = new List<Categories>()
            {
                new Categories() { category_id = 31, category_name = "FILM AND ANIMATION", category_adult = 0 },
                new Categories() { category_id = 32, category_name = "COMEDY", category_adult = 0 },
                new Categories() { category_id = 33, category_name = "EDUCATION", category_adult = 0 },
                new Categories() { category_id = 34, category_name = "ENTERTAINMENT", category_adult = 0 },
                new Categories() { category_id = 37, category_name = "THRILLER", category_adult = 1 },
                new Categories() { category_id = 36, category_name = "GAMING", category_adult = 0 }
            };

            this.mock.Setup(x => x.GetAll()).Returns(list.AsQueryable());

            this.logic = new CategoriesLogic(this.mock.Object);
        }

        /// <summary>
        /// Create a new mocked repository and checks to be empty.
        /// </summary>
        [Test]
        public void EmptyRepository()
        {
            Mock<IRepository<Categories>> empty = new Mock<IRepository<Categories>>();
            empty.Setup(x => x.GetAll()).Returns(new List<Categories>().AsQueryable());

            CategoriesLogic l = new CategoriesLogic(empty.Object);

            Assert.That(l.GetAll().Count(), Is.Zero);
        }

        /// <summary>
        /// Query by name, and contains what we search.
        /// </summary>
        /// <param name="name">String name parameter</param>
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

        /// <summary>
        /// Query by id, and contains what we search.
        /// </summary>
        /// <param name="id">Integer ID parameter.</param>
        [Test]
        [Sequential]
        public void GetElementByIdAndItIsExists([Values(31, 32, 34, 36)] int id)
        {
            var q = this.logic.GetElementById(id).First();

            Assert.That(q, Is.Not.Null);
        }

        /// <summary>
        /// Insert test with rigth input parameter.
        /// </summary>
        [Test]
        public void InsertWithRigthParameters()
        {
            Assert.That(() => this.logic.Insert(new Categories() { category_id = 999, category_name = "Test1", category_adult = 0 }), Throws.Nothing);
        }

        /// <summary>
        /// Insert test with bad input parameter.
        /// </summary>
        [Test]
        public void InsertWithBadParameters()
        {
            Assert.That(() => this.logic.Insert(new Categories() { category_id = 999, category_name = "Test1", category_adult = int.Parse("test") }), Throws.Exception);
        }

        /// <summary>
        /// Update test with rigth input parameter.
        /// </summary>
        [Test]
        public void UpdateWithRigthParameters()
        {
            Assert.That(() => this.logic.Update(new Categories() { category_id = 999, category_name = "Test1", category_adult = 0 }), Throws.Nothing);
        }

        /// <summary>
        /// Update test with bad input parameter.
        /// </summary>
        [Test]
        public void UpdateWithBadParameters()
        {
            Assert.That(() => this.logic.Insert(new Categories() { category_id = 999, category_name = "Test1", category_adult = int.Parse("test") }), Throws.Exception);
        }

        /// <summary>
        /// Delete test with rigth input parameter.
        /// </summary>
        [Test]
        public void DeleteWithRigthParameters()
        {
            Assert.That(() => this.logic.Update(new Categories() { category_id = 999, category_name = "Test1", category_adult = 0 }), Throws.Nothing);
        }

        /// <summary>
        /// Delete test with bad input parameter.
        /// </summary>
        [Test]
        public void DeleteWithBadParameters()
        {
            Assert.That(() => this.logic.Insert(new Categories() { category_id = 999, category_name = "Test1", category_adult = int.Parse("test") }), Throws.Exception);
        }
    }
}