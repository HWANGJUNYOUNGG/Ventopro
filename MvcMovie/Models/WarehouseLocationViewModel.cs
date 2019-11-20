using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class WarehouseLocationViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList p_locations { get; set; }
        public string Warehousew_location { get; set; }
        public string SearchString { get; set; }
    }
}
