namespace Web.PortalTemplate.Configuration
{
  using AutoMapper;

  /// <summary>
  /// MapperConfiguration class.
  /// </summary>
  public static class MainAutoMapperConfiguration
  {
    /// <summary>
    /// Creates the map.
    /// </summary>
    public static void CreateMap()
    {
      Mapper.Initialize(x =>
      {
        x.AddProfile<MainAutoMapperProfile>();
      });
    }
  }
}