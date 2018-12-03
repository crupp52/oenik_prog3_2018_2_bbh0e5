// <copyright file="LogicVideosTests.cs" company="PlaceholderCompany">
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
    /// VideosLogic test methods.
    /// </summary>
    [TestFixture]
    public class LogicVideosTests
    {
        private Mock<IRepository<Videos>> mock;
        private VideosLogic logic;

        /// <summary>
        /// Creates the mocked repository, and fills it up.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.mock = new Mock<IRepository<Videos>>();
            List<Videos> list = new List<Videos>()
            {
                new Videos() { video_id = 1, video_title = "test_title_01", video_description = "test", video_views = 3413, category_id = 31 },
                new Videos() { video_id = 2, video_title = "test_title_02", video_description = "test", video_views = 542423, category_id = 35 },
                new Videos() { video_id = 3, video_title = "test_title_03", video_description = "test", video_views = 132, category_id = 32 },
                new Videos() { video_id = 4, video_title = "test_title_04", video_description = "test", video_views = 767, category_id = 39 }
            };

            this.mock.Setup(x => x.GetAll()).Returns(list.AsQueryable());

            this.logic = new VideosLogic(this.mock.Object);
        }

        /// <summary>
        /// Query by name, and contains what we search.
        /// </summary>
        [Test]
        public void GetElementByName_ContaintTestString()
        {
            var q = this.logic.GetElementByName("test");

            foreach (var item in q)
            {
                Assert.That(item.video_title.Contains("test"));
            }
        }

        /// <summary>
        /// Test that the views are bigger than zero.
        /// </summary>
        [Test]
        public void AllViewsMoreThanZero()
        {
            var q = this.logic.GetAll();

            foreach (var item in q)
            {
                Assert.That(item.video_views, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Query by id, and contains what we search.
        /// </summary>
        /// <param name="id">Integer ID parameter.</param>
        [Test]
        [Sequential]
        public void GetElementByIdAndItIsExists([Values(1, 2, 3, 4)]int id)
        {
            var q = this.logic.GetElementById(id).First();

            Assert.That(q, Is.Not.Null);
        }
    }
}