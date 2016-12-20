namespace DAL.PortalTemplate
{
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public interface IRepository<TEntity>
  {
    //TEntity GetById(TKey id);
    void Create(TEntity entity);
    //void Update(TEntity entity);
    //void Delete(TEntity entity);

    IEnumerable<User> GetAll();
  }
}
