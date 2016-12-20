namespace DAL.PortalTemplate
{
  using Plugins.PortalTemplate.Model;
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Xml.Serialization;

  class ConcurrentXMLUserReporitory<TEntity> : IConcurrentRepository<TEntity> where TEntity : User
  {
    public void Create(TEntity user)
    {
      using (StreamWriter sw = new StreamWriter("Users.xml", true))
      {
        TextWriter synchronizedSw = TextWriter.Synchronized(sw);
        XmlSerializer serializer = new XmlSerializer(typeof(TEntity));
        serializer.Serialize(synchronizedSw, user);
        synchronizedSw.WriteLineAsync();
        sw.Close();
      }
    }
  }
}
