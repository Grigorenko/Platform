using System.Collections.Generic;
using Core.Data;
using Example.Data.Entities;

namespace Example.Data.Abstractions
{
  public interface IEntityRepository : IRepository
  {
    IEnumerable<Entity> All();
  }
}
