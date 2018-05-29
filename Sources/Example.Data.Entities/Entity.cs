using Core.Data;

namespace Example.Data.Entities
{
  public class Entity : IEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
