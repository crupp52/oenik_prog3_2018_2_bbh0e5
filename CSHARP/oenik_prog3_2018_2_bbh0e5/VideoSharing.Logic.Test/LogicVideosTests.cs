﻿// <copyright file="LogicVideosTests.cs" company="PlaceholderCompany">
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
        /// Create a new mocked repository and checks to be empty.
        /// </summary>
        [Test]
        public void EmptyRepository()
        {
            Mock<IRepository<Videos>> empty = new Mock<IRepository<Videos>>();
            empty.Setup(x => x.GetAll()).Returns(new List<Videos>().AsQueryable());

            VideosLogic l = new VideosLogic(empty.Object);

            Assert.That(l.GetAll().Count(), Is.Zero);
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

        /// <summary>
        /// Insert test with rigth input parameter.
        /// </summary>
        [Test]
        public void InsertWithRigthParameters()
        {
            Assert.That(() => this.logic.Insert(new Videos() { video_id = 999, video_title = "test", video_description = "test", video_views = 1000, category_id = 35 }), Throws.Nothing);
        }

        /// <summary>
        /// Insert test with bad input parameter.
        /// </summary>
        [Test]
        public void InsertWithBadParameters()
        {
            Assert.That(() => this.logic.Insert(new Videos() { video_id = 999, video_title = "test", video_description = "test", video_views = int.Parse("test"), category_id = 35 }), Throws.Exception);
        }

        /// <summary>
        /// Update test with rigth input parameter.
        /// </summary>
        [Test]
        public void UpdateWithRigthParameters()
        {
            Assert.That(() => this.logic.Update(new Videos() { video_id = 999, video_title = "test", video_description = "test", video_views = 1000, category_id = 35 }), Throws.Nothing);
        }

        /// <summary>
        /// Update test with bad input parameter.
        /// </summary>
        [Test]
        public void UpdateWithBadParameters()
        {
            Assert.That(() => this.logic.Insert(new Videos() { video_id = 999, video_title = "test", video_description = "test", video_views = int.Parse("test"), category_id = 35 }), Throws.Exception);
        }

        /// <summary>
        /// Delete test with rigth input parameter.
        /// </summary>
        [Test]
        public void DeleteWithRigthParameters()
        {
            Assert.That(() => this.logic.Update(new Videos() { video_id = 999, video_title = "test", video_description = "test", video_views = 1000, category_id = 35 }), Throws.Nothing);
        }

        /// <summary>
        /// Delete test with bad input parameter.
        /// </summary>
        [Test]
        public void DeleteWithBadParameters()
        {
            Assert.That(() => this.logic.Insert(new Videos() { video_id = 999, video_title = "test", video_description = "test", video_views = int.Parse("test"), category_id = 35 }), Throws.Exception);
        }
    }
}