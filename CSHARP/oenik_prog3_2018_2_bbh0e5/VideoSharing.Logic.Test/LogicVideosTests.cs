// <copyright file="LogicVideosTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic.Test
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Moq;
    using NUnit.Framework;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    [TestFixture]
    class LogicVideosTests
    {
        Mock<IRepository<Videos>> mock;
        VideosLogic logic;

        [SetUp]
        public void Setup()
        {
            this.mock = new Mock<IRepository<Videos>>();
            List<Videos> list = new List<Videos>()
            {
                new Videos() { video_id = 1, video_title = "test_title_01", video_description = "test", video_views = 3413, category_id = 31},
                new Videos() { video_id = 2, video_title = "test_title_02", video_description = "test", video_views = 542423, category_id = 35},
                new Videos() { video_id = 3, video_title = "test_title_03", video_description = "test", video_views = 132, category_id = 32},
                new Videos() { video_id = 4, video_title = "test_title_04", video_description = "test", video_views = 767, category_id = 39}
            };

            this.mock.Setup(x => x.GetAll()).Returns(list.AsQueryable());

            logic = new VideosLogic(mock.Object);
        }

        [Test]
        [Sequential]
        public void Test([Values(31, 35, 39)] int categoryId)
        {
            var q = (from e in this.logic.GetAll()
                    where e.category_id == categoryId
                    select e).First();

            Assert.That(q.category_id, Is.EqualTo(categoryId));
        }
    }
}
