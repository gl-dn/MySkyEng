using MySkyEng.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetById(long id);
        Task<TEntity> Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
