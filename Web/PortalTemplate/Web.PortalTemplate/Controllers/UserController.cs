namespace Web.PortalTemplate.Controllers
{
  using AutoMapper;
  using DAL.PortalTemplate;
  using Models;
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;
  using System.Web.Mvc;

  public class UserController : Controller
  {
    public UserController()
    {
      this.rp = new UserRepository<User>();
    }

    public ActionResult Index()
    {
      List<User> users = this.rp.GetAll().OrderByDescending(o => o.Id).ToList();
      var vm = Mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);

      return View(vm);
    }

    public ActionResult Create(UserModel model)
    {
      
      ViewBag.Submitted = false;
      var created = false;

      if (HttpContext.Request.RequestType == "POST"
          && ModelState.IsValid)
      {
        ViewBag.Submitted = true;

        User user = Mapper.Map<UserModel, User> (model);
        rp.Create(user);

        created = true;
      }

      if (created)
      {
        ViewBag.Message = "New user was created successfully.";
        ModelState.Clear();
      }

      return View(new UserModel());
    }

    private IRepository<User> rp;
  }
}