using Microsoft.Extensions.Options;

namespace Core.Data.Dapper
{
  public class StorageContext : StorageContextBase
  {
    public StorageContext(IOptions<StorageContextOptions> options) : base(options)
    {
    }
  }
}
