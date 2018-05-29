using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace Core.Infrastructure
{
  public static class ExtensionManager
  {
    private static IEnumerable<Assembly> assemblies;

    public static IEnumerable<Assembly> Assemblies
    {
      get
      {
        return ExtensionManager.assemblies;
      }
    }

    public static void SetAssemblies(IEnumerable<Assembly> assemblies)
    {
      ExtensionManager.assemblies = assemblies;
    }

    public static T GetInstance<T>() =>
     ExtensionManager.GetInstance<T>(null);

    public static IEnumerable<T> GetInstances<T>() =>
      ExtensionManager.GetInstances<T>(null);

    public static T GetInstance<T>(Func<Assembly, bool> predicate) =>
      ExtensionManager.GetInstances<T>(predicate).FirstOrDefault();

    public static IEnumerable<Type> GetImplementations<T>() =>
      ExtensionManager.GetImplementations<T>(null);

    private static IEnumerable<T> GetInstances<T>(Func<Assembly, bool> predicate) =>
      ExtensionManager.GetImplementations<T>(predicate)
        .Where(i => !i.GetTypeInfo().IsAbstract)
        .Select(i => (T)Activator.CreateInstance(i));

    private static IEnumerable<Type> GetImplementations<T>(Func<Assembly, bool> predicate) =>
      AppDomain.CurrentDomain.GetAssemblies()
        .Where(predicate == null ? ((flag) => true) : predicate)
        .Where(p => !p.IsDynamic)
        .Select(a => a.GetExportedTypes())
        .SelectMany(ty => ty.Where(t => typeof(T).GetTypeInfo().IsAssignableFrom(t) &&
                                        t.GetTypeInfo().IsClass));
  }
}
