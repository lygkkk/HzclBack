using System;
using System.Collections.Generic;

namespace HzclBack.Abstract.IBaseInfoService
{
    public interface IBaseService<TEntity> where TEntity : class, new()
    {
        int AddTEntity(TEntity tEntity);
        int AddTEntities(List<TEntity> tEntities);
        int UpdateTEntity(TEntity tEntity);
        int UpdateTEntities(List<TEntity> tEntities);

        TEntity GetEntity(Func<TEntity, bool> where);
        IEnumerable<TEntity> GetEntities(Func<TEntity, bool> where);
    }
}