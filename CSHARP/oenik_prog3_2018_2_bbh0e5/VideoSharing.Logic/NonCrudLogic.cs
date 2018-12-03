// <copyright file="NonCrudLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    /// <summary>
    /// Contains the non CRUD queries of the DB
    /// </summary>
    public class NonCrudLogic
    {
        private IRepository<Creators> creatorsRepo;
        private IRepository<Categories> categoriesRepo;
        private IRepository<Videos> videosRepo;
        private IRepository<Uploads> uploadsRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="NonCrudLogic"/> class.
        /// Declares the crud logics.
        /// </summary>
        public NonCrudLogic()
        {
            this.creatorsRepo = new CreatorRepository();
            this.categoriesRepo = new CategoryRepository();
            this.videosRepo = new VideoRepository();
            this.uploadsRepo = new UploadRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NonCrudLogic"/> class.
        /// Alternative constructor for custom mocked repositories.
        /// </summary>
        /// <param name="videoRepo">Usually it will be a mocked VideosRepository repository.</param>
        /// <param name="categoryRepo">Usually it will be a mocked CategoriesRepository repository.</param>
        /// <param name="creatorRepo">Usually it will be a mocked CreatorsRepository repository.</param>
        /// <param name="uploadRepo">Usually it will be a mocked UploadsRepository repository.</param>
        public NonCrudLogic(IRepository<Videos> videoRepo, IRepository<Categories> categoryRepo, IRepository<Creators> creatorRepo, IRepository<Uploads> uploadRepo)
        {
            this.creatorsRepo = creatorRepo;
            this.categoriesRepo = categoryRepo;
            this.videosRepo = videoRepo;
            this.uploadsRepo = uploadRepo;
        }

        /// <summary>
        /// Get the Video titles and and associated categories.
        /// </summary>
        /// <returns>List of video and categories pairs.</returns>
        public List<string> VideoAndCategory()
        {
            var videos = (from e in this.videosRepo.GetAll()
                                   select e).ToList();
            var categories = (from e in this.categoriesRepo.GetAll()
                                select e).ToList();

            var q = from e in videos
                    select new { Video = e.video_title, Category = e.Categories.category_name };

            List<string> output = new List<string>();

            foreach (var item in q)
            {
                output.Add($"{item.Video} - {item.Category}");
            }

            return output;
        }

        /// <summary>
        /// Get the Video titles and and associated creator names and views.
        /// </summary>
        /// <returns>List of video, creator and view records.</returns>
        public List<string> VideoCreatorViews()
        {
            var videos = (from e in this.videosRepo.GetAll()
                          select e).ToList();

            var q = from e in videos
                    join f in this.uploadsRepo.GetAll() on e.video_id equals f.video_id
                    select new { Video = e.video_title, Creator = f.Creators.creator_name, View = e.video_views };

            List<string> output = new List<string>();

            foreach (var item in q)
            {
                output.Add($"{item.Video} - {item.Creator} - {item.View}");
            }

            return output;
        }

        /// <summary>
        /// Lists the most viewed videos in the DB.
        /// </summary>
        /// <returns>Returns the top 5 video titles and number of views.</returns>
        public List<string> MostViewedVideos()
        {
            var q = (from e in this.videosRepo.GetAll()
                     orderby e.video_views descending
                     select new { Title = e.video_title, View = e.video_views }).Take(5);

            List<string> output = new List<string>();

            foreach (var item in q)
            {
                output.Add($"{item.Title} - {item.View}");
            }

            return output;
        }
    }
}
