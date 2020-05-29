using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public bool RegularClient { get; set; }
    public string Usual { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}