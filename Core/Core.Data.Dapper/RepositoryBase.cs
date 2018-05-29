
namespace Core.Data.Dapper
{
  public abstract class RepositoryBase<TEntity> : IRepository where TEntity : class, IEntity
  {
    protected IStorageContext storageContext;
    protected string connectionString;

    public void SetStorageContext(IStorageContext storageContext)
    {
      this.storageContext = storageContext;
      this.connectionString = (storageContext as StorageContextBase).ConnectionString;
    }
  }
}
