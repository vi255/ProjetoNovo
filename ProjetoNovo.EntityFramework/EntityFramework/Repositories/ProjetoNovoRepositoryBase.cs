using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ProjetoNovo.EntityFramework.Repositories
{
    public abstract class ProjetoNovoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProjetoNovoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProjetoNovoRepositoryBase(IDbContextProvider<ProjetoNovoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ProjetoNovoRepositoryBase<TEntity> : ProjetoNovoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProjetoNovoRepositoryBase(IDbContextProvider<ProjetoNovoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
