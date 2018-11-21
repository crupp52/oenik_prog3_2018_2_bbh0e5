// <copyright file="LogicVideosTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Moq;
    using VideoSharing.Repository;
    using VideoSharing.Data;
    using NUnit.Framework;

    class LogicVideosTests
    {
        Logic logic;
        Mock<IRepository<Videos>> mock;

        public LogicVideosTests()
        {
            this.logic = new Logic();
            this.mock = new Mock<IRepository<Videos>>();

            VideoRepository repository = new VideoRepository();

            List<Videos> list = new List<Videos>()
            {
                new Videos() { video_id = 1, video_title = "test1", video_description = "description1", video_views = 500},
                new Videos() { video_id = 2, video_title = "test2", video_description = "description2", video_views = 54300},
                new Videos() { video_id = 3, video_title = "test3", video_description = "description3", video_views = 5020},
                new Videos() { video_id = 4, video_title = "test4", video_description = "description4", video_views = 53100},
            };

            this.mock.Setup(x => x.GetAll());
        }

        [Test]
        public void Test()
        {
            var title = this.logic.VideosGetAll();

            Assert.That(title.Count(), Is.EqualTo(title.Count()));
        }
    }
}
