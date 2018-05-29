using System.Reflection;
using System.Collections.Generic;

namespace Core.Infrastructure
{
  public interface IAssemblyProvider
  {
    IEnumerable<Assembly> GetAssemblies(string path, bool includingSubpaths);
  }
}
