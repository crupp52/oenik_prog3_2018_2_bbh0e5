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
                new Videos() { video_id = 1, video_title = "LECSAPOLT ÓCEÁN - 1. RÉSZ", video_description = "NATGEO TV - EREDETI SOROZAT", video_views = 18321, category_id = 33 },
                new Videos() { video_id = 2, video_title = "LECSAPOLT ÓCEÁN - 3. RÉSZ", video_description = "NATGEO TV - EREDETI SOROZAT", video_views = 41423, category_id = 33 },
                new Videos() { video_id = 3, video_title = "GET OUT (2017)", video_description = "EGÉSZ ESTÉS HORROR FILM", video_views = 73273, category_id = 38 },
                new Videos() { video_id = 4, video_title = "KING KONG (1933)", video_description = "KLASSZIKUS HORROR, A LEGJOBBAK KÖZÖTT VAN!", video_views = 547834, category_id = 38 }
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
        /// <param name="input">Contains the title list of videos.</param>
        [Test]
        [Sequential]
        public void GetElementByName_ContaintTestString([Values("LECSAPOLT ÓCEÁN - 1. RÉSZ", "LECSAPOLT ÓCEÁN - 3. RÉSZ", "GET OUT (2017)", "KING KONG (1933)")] string input)
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
        /// Testing that logic calls the insert method in Repository.
        /// </summary>
        [Test]
        public void LogicCallsTheRepoInsert()
        {
            this.logic.Insert(It.IsAny<Videos>());

            this.mock.Verify(x => x.Insert(It.IsAny<Videos>()), Times.Once);
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
        /// Testing that logic calls the Update method in Repository.
        /// </summary>
        [Test]
        public void LogicCallsTheRepoUpdate()
        {
            this.logic.Update(It.IsAny<Videos>());

            this.mock.Verify(x => x.Update(It.IsAny<Videos>()), Times.Once);
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
        /// Testing that logic calls the Delete method in Repository.
        /// </summary>
        [Test]
        public void LogicCallsTheRepoDelete()
        {
            this.logic.Delete(It.IsAny<Videos>());

            this.mock.Verify(x => x.Delete(It.IsAny<Videos>()), Times.Once);
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