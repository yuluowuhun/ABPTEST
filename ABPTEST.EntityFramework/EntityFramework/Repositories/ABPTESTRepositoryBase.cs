using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPTEST.EntityFramework.Repositories
{
    public abstract class ABPTESTRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPTESTDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPTESTRepositoryBase(IDbContextProvider<ABPTESTDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPTESTRepositoryBase<TEntity> : ABPTESTRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPTESTRepositoryBase(IDbContextProvider<ABPTESTDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
