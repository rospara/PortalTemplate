namespace Web.PortalTemplate.Configuration
{
  using AutoMapper;
  using Models;
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;

  public class MainAutoMapperProfile : Profile
  {
    public MainAutoMapperProfile()
    {
      this.CreateMap<User, UserModel>();
      this.CreateMap<UserModel, User>();
    }
  }
}