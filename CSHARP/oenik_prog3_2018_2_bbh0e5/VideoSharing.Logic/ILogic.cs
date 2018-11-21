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
    /// asd
    /// </summary>
    /// <typeparam name="T">asd1</typeparam>
    public interface ILogic<T>
    {
        List<string> GetAll();
        T MakeObject(string[] parameters);
        void Insert(string[] parameters);
        void Update(string[] parameters);
        void Delete(string[] parameters);
    }
}
