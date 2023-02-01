using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Base;

namespace WhosNext_Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseDomain
    {
        #region Interfaces
        Task<IList<TEntity>> Select();
        Task<TEntity> Insert(TEntity obj);
        Task<TEntity> DeleteFirstBy(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SelectFirstBy(Expression<Func<TEntity, bool>> predicate);
        Task<IList<TEntity>> Select(Expression<Func<TEntity, bool>> predicate);

        #endregion
    }
}
