namespace DAL.PortalTemplate
{
  using Plugins.PortalTemplate.Model;

  class Program
  {
    static void Main(string[] args)
    {
      IRepository<User> rp = new UserRepository<User>();
      User user = new User() { Id = 1, Name = "Ala2", Surename = "Kowalska3" };
      rp.Create(user);
    }
  }
}
