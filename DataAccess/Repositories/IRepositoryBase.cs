﻿namespace DataAccess.Repositories
{
    using System;
    using System.Collections.Generic;

    public interface IRepositoryBase<T> where T : class
    {
        List<T> GetAll();

        T GetByID(int id);

        void Create(T item);

        void Update(T item, Func<T, bool> findByID);

    }
}
