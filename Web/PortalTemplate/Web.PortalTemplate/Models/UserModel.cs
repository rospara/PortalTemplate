namespace Web.PortalTemplate.Models
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.Linq;
  using System.Web;

  public class UserModel
  {
    public int Id { get; set; }

    [Required]
    [Display(Name = "Name")]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [Display(Name = "Surename")]
    [MaxLength(50)]
    public string Surename { get; set; }
  }
}