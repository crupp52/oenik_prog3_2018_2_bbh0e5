// <copyright file="ILogic.cs" company="PlaceholderCompany">
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
    /// Containt all must have datebase queries list.
    /// </summary>
    public interface ILogic
    {
        void CategoriesDelete(int id);
        List<string> CategoriesGetAll();
        void CategoriesInsert(string[] parameters);
        void CategoriesUpdate(string[] parameters);

        void VideosDelete(int id);
        List<string> VideosGetAll();
        void VideosInsert(string[] parameters);
        void VideosUpdate(string[] parameters);

        void CreatorsDelete(int id);
        List<string> CreatorsGetAll();
        void CreatorsInsert(string[] parameters);
        void CreatorsUpdate(string[] parameters);

        void UploadsDelete(int id);
        List<string> UploadsGetAll();
        void UploadsInsert(string[] parameters);
        void UploadsUpdate(string[] parameters);
    }
}
