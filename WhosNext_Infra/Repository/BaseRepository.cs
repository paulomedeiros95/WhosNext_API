using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Base;
using WhosNext_Domain.Interfaces;
using WhosNext_Infra.Context;

namespace WhosNext_Infra.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseDomain
    {
        #region Fields
        protected readonly ApplicationDbContext DbContext;
        #endregion

        #region Constructor
        public BaseRepository(ApplicationDbContext dbontext)
        {
            DbContext = dbontext;
        }

        #endregion

        #region Methods
        public async Task<TEntity> Insert(TEntity obj)
        {
            obj.CreatedAt = DateTime.Now;
            var user = await DbContext.Set<TEntity>().AddAsync(obj);
            await DbContext.SaveChangesAsync();

            return user.Entity;
        }

        public async Task<TEntity> DeleteFirstBy(Expression<Func<TEntity, bool>> predicate)
        {
            var data = await SelectFirstBy(predicate);
            data.UpdatedAt = DateTime.Now;
            data.DeletedAt = DateTime.Now;
            DbContext.Entry(data).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();

            return data;

        }
        public async Task<IList<TEntity>> Select() =>
           await DbContext.Set<TEntity>().Where(x => x.DeletedAt == null).ToListAsync();

        public async Task<IList<TEntity>> Select(Expression<Func<TEntity, bool>> predicate) =>
            await DbContext.Set<TEntity>().Where(predicate).Where(x => x.DeletedAt == null).ToListAsync();

        public async Task<TEntity> SelectFirstBy(Expression<Func<TEntity, bool>> predicate) =>
            await DbContext.Set<TEntity>().FirstOrDefaultAsync(predicate);

        #endregion
    }
}
