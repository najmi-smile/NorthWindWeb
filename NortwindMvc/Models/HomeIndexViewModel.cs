using NorthwindEntitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NortwindMvc.Models
{
    public class HomeIndexViewModel
    {
        public int vistorCount;
        public IList<Category> Categories { get; set; }
        public IList<Product> Products { get; set; }

    }
}
