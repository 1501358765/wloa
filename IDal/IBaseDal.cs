using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDal
{
    public interface IBaseDal<TEntity> where TEntity:class
    {
        TEntity Add(TEntity entity);
        void UpDate(TEntity entity, string[] propertys);
        void Remove(TEntity entity);
        IQueryable<TEntity> WhereAll();
        IQueryable<TEntity> WhereByConditity(Expression<Func<TEntity, bool>> expression);
        int SaveChanges();
    }
}
