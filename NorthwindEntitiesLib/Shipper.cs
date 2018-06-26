using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindEntitiesLib
{
    public class Shipper
    {
      [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int ShipperID { get; set; }
      public string ShipperName { get; set; }
      public string Phone { get; set; }
      public ICollection<Order> Orders { get; set; }
    }
}