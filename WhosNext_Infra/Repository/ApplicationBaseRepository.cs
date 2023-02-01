using WhosNext_Domain.Base;
using WhosNext_Infra.Context;

namespace WhosNext_Infra.Repository
{
    public class ApplicationBaseRepository<TEntity> : BaseRepository<TEntity> where TEntity : BaseDomain
    {
        #region Fields

        protected ApplicationDbContext DbContext;

        #endregion

        #region Constructor

        public ApplicationBaseRepository(ApplicationDbContext dbontext) : base(dbontext)
        {
            DbContext = dbontext;
        }

        #endregion
    }
}
