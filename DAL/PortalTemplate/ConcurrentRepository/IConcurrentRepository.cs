namespace DAL.PortalTemplate
{
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  internal interface IConcurrentRepository<TEntity> 
  {
    void Create(TEntity entity);
  }
}
