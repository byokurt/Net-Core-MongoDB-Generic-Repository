﻿using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDBExample.Data.Repository.Implementations
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly IMongoDBContext _mongoContext;
        protected IMongoCollection<T> _dbCollection;

        protected BaseRepository(IMongoDBContext context)
        {
            _mongoContext = context;
            _dbCollection = _mongoContext.GetCollection<T>(typeof(T).Name);
        }

        public virtual T Add(T entity)
        {
            _dbCollection.InsertOne(entity);
            return entity;
        }

        public virtual T GetById(Guid id)
        {
            var data = _dbCollection.Find(Builders<T>.Filter.Eq("_id", id));
            return data.FirstOrDefault();
        }

        public virtual void Remove(Guid id)
        {
            _dbCollection.DeleteOne(Builders<T>.Filter.Eq("_id", id));
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbCollection.Find(Builders<T>.Filter.Empty).ToList();
        }

        public void Update(T entity)
        {
            _dbCollection.ReplaceOne(Builders<T>.Filter.Eq("_id", entity.Id), entity);
        }
    }
}