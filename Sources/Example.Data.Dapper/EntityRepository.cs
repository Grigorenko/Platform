using Core.Data.Dapper;
using Dapper;
using Example.Data.Abstractions;
using Example.Data.Entities;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Data;

namespace Example.Data.Dapper
{
  public class EntityRepository : RepositoryBase<Entity>, IEntityRepository
  {
    public IEnumerable<Entity> All()
    {
      using (IDbConnection db = new SqliteConnection(this.connectionString))
      {
        return db.Query<Entity>("SELECT * FROM Entities");
      }
    }
  }
}