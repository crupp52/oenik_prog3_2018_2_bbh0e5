// <copyright file="Logic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoSharing.Repository;

    /// <summary>
    /// Implement the ILogic methods and functions.
    /// </summary>
    public class Logic : ILogic
    {
        public UploadRepository UploadRepo { get; private set; }

        public CreatorRepository CreatorRepo { get; private set; }

        public VideoRepository VideoRepo { get; private set; }

        public CategoryRepository CategoryRepo { get; private set; }

        public Logic()
        {
            this.UploadRepo = new UploadRepository();
            this.CreatorRepo = new CreatorRepository();
            this.VideoRepo = new VideoRepository();
            this.CategoryRepo = new CategoryRepository();
        }

        public void CategoriesDelete(int id)
        {
            this.CategoryRepo.Delete(id);
        }

        public List<string> CategoriesGetAll()
        {
            return this.CategoryRepo.GetAll();
        }

        public void CategoriesInsert(string[] parameters)
        {
            this.CategoryRepo.Insert(parameters);
        }

        public void CategoriesUpdate(string[] parameters)
        {
            this.CategoryRepo.Update(parameters);
        }

        public void VideosDelete(int id)
        {
            this.VideoRepo.Delete(id);
        }

        public List<string> VideosGetAll()
        {
            return this.VideoRepo.GetAll();
        }

        public void VideosInsert(string[] parameters)
        {
            this.VideoRepo.Insert(parameters);
        }

        public void VideosUpdate(string[] parameters)
        {
            this.VideoRepo.Update(parameters);
        }

        public void CreatorsDelete(int id)
        {
            this.CreatorRepo.Delete(id);
        }

        public List<string> CreatorsGetAll()
        {
            return this.CreatorRepo.GetAll();
        }

        public void CreatorsInsert(string[] parameters)
        {
            this.CreatorRepo.Insert(parameters);
        }

        public void CreatorsUpdate(string[] parameters)
        {
            this.CreatorRepo.Update(parameters);
        }

        public void UploadsDelete(int id)
        {
            this.UploadRepo.Delete(id);
        }

        public List<string> UploadsGetAll()
        {
            return this.UploadRepo.GetAll();
        }

        public void UploadsInsert(string[] parameters)
        {
            this.UploadRepo.Insert(parameters);
        }

        public void UploadsUpdate(string[] parameters)
        {
            this.UploadRepo.Update(parameters);
        }
    }
}
