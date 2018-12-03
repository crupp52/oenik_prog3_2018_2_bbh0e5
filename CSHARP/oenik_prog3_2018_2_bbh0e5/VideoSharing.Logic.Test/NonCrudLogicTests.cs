// <copyright file="NonCrudLogicTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Moq;
    using NUnit.Framework;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    /// <summary>
    /// Testing the non CRUD logic methods
    /// </summary>
    [TestFixture]
    public class NonCrudLogicTests
    {
        private NonCrudLogic logic;
        private Mock<IRepository<Categories>> mCategory;
        private Mock<IRepository<Creators>> mCreator;
        private Mock<IRepository<Videos>> mVideo;
        private Mock<IRepository<Uploads>> mUploads;

        /// <summary>
        /// Creates the mocked repository, and fills it up.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.mVideo = new Mock<IRepository<Videos>>();
            this.mCreator = new Mock<IRepository<Creators>>();
            this.mCategory = new Mock<IRepository<Categories>>();
            this.mUploads = new Mock<IRepository<Uploads>>();

            List<Videos> videos = new List<Videos>()
            {
                new Videos() { video_id = 1, video_title = "test_title_01", video_description = "test", video_views = 3413, category_id = 31 },
                new Videos() { video_id = 2, video_title = "test_title_02", video_description = "test", video_views = 542423, category_id = 35 },
                new Videos() { video_id = 3, video_title = "test_title_03", video_description = "test", video_views = 132, category_id = 32 },
                new Videos() { video_id = 4, video_title = "test_title_04", video_description = "test", video_views = 767, category_id = 39 }
            };

            List<Creators> creaotrs = new List<Creators>()
            {
                new Creators() { creator_id = 1, creator_name = "AVA JACKSON", creator_email = "AVA.JACKSON18@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1980-10-06"), creator_premium = 1 },
                new Creators() { creator_id = 4, creator_name = "ISOBEL HANSEN", creator_email = "ISOBEL.HANSEN75@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1975-03-13"), creator_premium = 0 },
                new Creators() { creator_id = 5, creator_name = "JOSE CHAPMAN", creator_email = "JOSE.CHAPMAN13@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1977-01-11"), creator_premium = 1 },
                new Creators() { creator_id = 6, creator_name = "LAURIE GEORGE", creator_email = "LAURIE.GEORGE14@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1977-07-13"), creator_premium = 1 },
                new Creators() { creator_id = 13, creator_name = "MARCUS FRANKLIN", creator_email = "MARCUS FRANKLIN@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1986-10-27"), creator_premium = 0 },
                new Creators() { creator_id = 15, creator_name = "SOFIA BISHOP", creator_email = "SOFIA.BISHOP21@EXAMPLE.COM", creator_birth_date = DateTime.Parse("1987-07-16"), creator_premium = 0 }
            };

            List<Categories> categories = new List<Categories>()
            {
                new Categories() { category_id = 31, category_name = "FILM AND ANIMATION", category_adult = 0 },
                new Categories() { category_id = 32, category_name = "COMEDY", category_adult = 0 },
                new Categories() { category_id = 33, category_name = "EDUCATION", category_adult = 0 },
                new Categories() { category_id = 34, category_name = "ENTERTAINMENT", category_adult = 0 },
                new Categories() { category_id = 37, category_name = "THRILLER", category_adult = 1 },
                new Categories() { category_id = 36, category_name = "GAMING", category_adult = 0 }
            };

            List<Uploads> uploads = new List<Uploads>()
            {
                new Uploads() { upload_id = 100, upload_date = DateTime.Parse("2018.10.10"), creator_id = 1, video_id = 1 },
                new Uploads() { upload_id = 101, upload_date = DateTime.Parse("2018.10.20"), creator_id = 4, video_id = 4 }
            };

            this.mVideo.Setup(x => x.GetAll()).Returns(videos.AsQueryable());

            this.mCreator.Setup(x => x.GetAll()).Returns(creaotrs.AsQueryable());

            this.mCategory.Setup(x => x.GetAll()).Returns(categories.AsQueryable());

            this.mUploads.Setup(x => x.GetAll()).Returns(uploads.AsQueryable());

            this.logic = new NonCrudLogic(this.mVideo.Object, this.mCategory.Object, this.mCreator.Object, this.mUploads.Object);
        }
    }
}
