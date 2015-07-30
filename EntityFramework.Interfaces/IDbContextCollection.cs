﻿/* 
 * Copyright (C) 2014 Mehdi El Gueddari
 * http://mehdi.me
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 */
using System;
using System.Data;
using System.Data.Entity;

namespace Numero3.EntityFramework.Interfaces
{
    /// <summary>
    /// Maintains a list of lazily-created DbContext instances.
    /// </summary>
    public interface IDbContextCollection : IDisposable
    {
        /// <summary>
        /// Get or create a DbContext instance of the specified type. 
        /// </summary>
        TDbContext Get<TDbContext>() where TDbContext : DbContext;

        /// <summary>
        /// Returns the IsolationLevel used to create transactions for DbContexts in this collection.
        /// </summary>
        IsolationLevel? IsolationLevel { get; }
    }
}