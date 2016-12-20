namespace DAL.PortalTemplate
{
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  internal class ConcurrentDBUserReporitory<TEntity> : IConcurrentRepository<TEntity> where TEntity : User
  {
    public ConcurrentDBUserReporitory() 
    {
      dbContext = new PortalTemplateDBContext();
    }

    public void Create(TEntity user)
    {
      if (user == null)
      {
        throw new ArgumentNullException("user");
      }

      DbContext.Set<TEntity>().Add(user);
      DbContext.SaveChangesAsync();

      //Console.WriteLine(String.Format("ConcurrentDBUserReporitory: {0} {1}", user.Name, user.Surename));
    }

    public IEnumerable<TEntity> GetAll()
    {
      return DbContext.Set<TEntity>().Where(x => true);
    }

    private bool disposed = false;

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposed)
      {
        return;
      }
        
      if (disposing)
      {
        // Free any other managed objects here.
        if (this.dbContext != null)
        {

          if (this.dbContext.Database != null && this.dbContext.Database.Connection != null)
          {
            this.dbContext.Database.Connection.Close();
          }


          this.dbContext.Dispose();
        }
      }

      // Free any unmanaged objects here.

      disposed = true;
    }

    protected PortalTemplateDBContext DbContext
    {
      get { return dbContext; }
    }

    private readonly PortalTemplateDBContext dbContext;
  }
}
