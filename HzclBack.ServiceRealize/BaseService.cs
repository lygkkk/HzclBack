using System;
using System.Collections.Generic;
using System.Linq;
using HzclBack.Abstract;
using HzclBack.Abstract.IBaseInfoService;
using HzclBack.EntityFramework;

namespace HzclBack.ServiceRealize
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class , new()
    {
        private readonly MariaDbContext _mariaDb;

        public BaseService(MariaDbContext mariaDb)
        {
            this._mariaDb = mariaDb;
        }

        public int AddTEntity(TEntity tEntity)
        {
            _mariaDb.Set<TEntity>().Add(tEntity);
            return _mariaDb.SaveChanges();
        }

        public int AddTEntities(List<TEntity> tEntities)
        {
            _mariaDb.Set<TEntity>().AddRange(tEntities);
            return _mariaDb.SaveChanges();
        }

        public int UpdateTEntity(TEntity tEntity)
        {
            _mariaDb.Set<TEntity>().Update(tEntity);
            return _mariaDb.SaveChanges();
        }

        public int UpdateTEntities(List<TEntity> tEntities)
        {
            _mariaDb.Set<TEntity>().UpdateRange(tEntities);
            return _mariaDb.SaveChanges();
        }

        public TEntity GetEntity(Func<TEntity, bool> @where)
        {
            return _mariaDb.Set<TEntity>().Single(where);
        }

        public IEnumerable<TEntity> GetEntities(Func<TEntity, bool> @where)
        {
            return _mariaDb.Set<TEntity>().Where(where);
        }
    }
}