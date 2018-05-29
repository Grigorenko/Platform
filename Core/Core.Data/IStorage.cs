
namespace Core.Data
{
  public interface IStorage
  {
    IStorageContext StorageContext { get; }
    T GetRepository<T>() where T : IRepository;
  }
}
