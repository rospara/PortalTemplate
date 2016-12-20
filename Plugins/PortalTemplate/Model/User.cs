namespace Plugins.PortalTemplate.Model
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.Linq;
  using System.Text;

  public class User
  {
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(50)]
    public string Surename { get; set; }
  } 
}
