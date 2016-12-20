namespace Plugins.PortalTemplate.Model
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Data.Entity;

  public class PortalTemplateDBContext : DbContext
  {
      public DbSet<User> Users { get; set; }
  }
}



               
    