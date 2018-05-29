using Microsoft.Extensions.Options;

namespace Core.Data.Dapper
{
  public class StorageContextBase : IStorageContext
  {
    public string ConnectionString { get; private set; }

    public StorageContextBase(IOptions<StorageContextOptions> options)
    {
      this.ConnectionString = options.Value.ConnectionString;
    }
  }
}
