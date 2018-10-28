﻿// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DAL.Abstractions
{
    using System.Collections.Generic;

    /// <summary>
    /// interface of repository.
    /// </summary>
    /// <typeparam name="TEntity">Stored entity.</typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Method to add entity.
        /// </summary>
        /// <param name="entity">entity to add.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Method to remove entity.
        /// </summary>
        /// <param name="entity">entity to remove.</param>
        void Remove(TEntity entity);

        /// <summary>
        /// get all elements from repository.
        /// </summary>
        /// <returns>returns all elements from repository.</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Remove all entities from repository.
        /// </summary>
        void RemoveAll();

        /// <summary>
        /// Save changes.
        /// </summary>
        /// <param name="path">path to file.</param>
        void SaveChanges(string path);
    }
}