namespace DAL.PortalTemplate
{
  using NLog;
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  class ConcurrentNLogUserReporitory<TEntity> : IConcurrentRepository<TEntity> where TEntity : User
  {
    public void Create(TEntity user)
    {
      logger.Info("New user created, Name={0}, Surename={1}", user.Name, user.Surename);
      //Console.WriteLine(String.Format("ConcurrentNLogUserReporitory: {0} {1}", user.Name, user.Surename));
    }

    private static Logger logger = LogManager.GetCurrentClassLogger();
  }
}
