using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BaseDal<TEntity> where TEntity:class
    {
        public DbContext db
        {
            get { return DbContextFactory.Factory.GetDbContext(); }
        }
        public TEntity Add(TEntity entity)
        {
            return db.Set<TEntity>().Add(entity);
        }
        public void UpDate(TEntity entity, string[] propertys)
        {
            //  db.Set<TEntity>().Attach(entity);
            if (propertys == null || propertys.Length == 0)
            {
                throw new Exception("传入的参数不正确");
            }
            //不进行实体追踪
            db.Configuration.ValidateOnSaveEnabled = false;

            db.Entry(entity).State = EntityState.Modified;
            foreach (string key in propertys)
            {
                db.Entry(entity).Property(key).IsModified = true;
            }
        }
        public void Remove(TEntity entity)
        {

            db.Set<TEntity>().Attach(entity);
            db.Set<TEntity>().Remove(entity);
        }
        public IQueryable<TEntity> WhereAll()
        {
            return db.Set<TEntity>().AsQueryable();
        }
        public IQueryable<TEntity> WhereByConditity(Expression<Func<TEntity, bool>> expression)
        {

            return db.Set<TEntity>().Where(expression).AsQueryable();

        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
