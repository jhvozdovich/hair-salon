using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int SalonId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
  }
}