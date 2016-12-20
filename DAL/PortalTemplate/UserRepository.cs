namespace DAL.PortalTemplate
{
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading;
  using System.Threading.Tasks;

  public class UserRepository<TEntity> : IRepository<TEntity> where TEntity : User
  {
    public void Create(TEntity entity)
    {
      List<IConcurrentRepository<User>> concurrentUserRepos = new List<IConcurrentRepository<User>>();
      concurrentUserRepos.Add(new ConcurrentDBUserReporitory<User>());
      concurrentUserRepos.Add(new ConcurrentXMLUserReporitory<User>());
      concurrentUserRepos.Add(new ConcurrentNLogUserReporitory<User>());

      Parallel.ForEach(concurrentUserRepos, (repo) =>
      {
        repo.Create(entity);
      });

      // Keep the console window open in debug mode.
      //Console.WriteLine("Processing complete. Press any key to exit.");
      //Console.ReadKey();
    }

    public IEnumerable<User> GetAll()
    {
      var dbUserRepo = new ConcurrentDBUserReporitory<User>();
      return dbUserRepo.GetAll();
    }
  }
}
