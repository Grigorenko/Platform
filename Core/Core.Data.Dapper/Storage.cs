using Core.Infrastructure;

namespace Core.Data.Dapper
{
  public class Storage : IStorage
    {
    public IStorageContext StorageContext { get; private set; }

    public Storage(IStorageContext storageContext)
    {
      this.StorageContext = storageContext;
    }

    public TRepository GetRepository<TRepository>() where TRepository : IRepository
    {
      TRepository repository = ExtensionManager.GetInstance<TRepository>();

      if (repository != null)
        repository.SetStorageContext(this.StorageContext);

      return repository;
    }
  }
}
