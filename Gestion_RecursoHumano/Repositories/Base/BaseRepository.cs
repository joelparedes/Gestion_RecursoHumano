
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Gestion_RecursoHumano.Repositories.Base
{
    public interface IBaseRepository<TEntity>
        where TEntity : Models.Base.BaseEntity
    {
        TEntity Find(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> expression);
        void Remove(int Id);
        void Update(TEntity entity, params Expression<Func<TEntity, object>>[] expression);
        void Save();
        bool Exist(Expression<Func<TEntity, bool>> expression);
        int Count(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
    }

    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : Models.Base.BaseEntity
    {
        public Context.GestionContext DataContext { get; set; }
        public DbSet<TEntity> EntityBase { get; set; }

        public BaseRepository(Context.GestionContext context)
        {
            this.DataContext = context;
            this.EntityBase = context.Set<TEntity>();
        }
        public TEntity Find(Expression<Func<TEntity, bool>> expression)
        {
            return this.EntityBase.Where(expression).FirstOrDefault();
        }
        public IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> expression)
        {
            return this.EntityBase.Where(expression);
        }

        public void Remove(int Id)
        {
            this.EntityBase.Remove(this.Find(x => x.Id == Id));
        }

        public void Update(TEntity entity, params Expression<Func<TEntity, object>>[] expression)
        {
            var dbEntity = this.DataContext.Entry(entity);
            if (expression.Any())
            {
                foreach(var item in expression)
                {
                    dbEntity.Property(item).IsModified = true;
                }
            }
            else
            {
                foreach(var item in dbEntity.OriginalValues.PropertyNames)
                {
                    var original = dbEntity.OriginalValues.GetValue<object>(item);
                    var current = dbEntity.CurrentValues.GetValue<object>(item);
                    if(original != null && !original.Equals(current))
                    {
                        dbEntity.Property(item).IsModified = true;
                    }
                }
            }
        }

        public void Save()
        {
            this.DataContext.SaveChanges();
        }

        public bool Exist(Expression<Func<TEntity, bool>> expression)
        {
            return this.EntityBase.Where(expression).Any();
        }

        public int Count(Expression<Func<TEntity, bool>> expression)
        {
            return this.EntityBase.Where(expression).Count();
        }

        public void Add(TEntity entity)
        {
            this.EntityBase.Add(entity);
        }
    }
}