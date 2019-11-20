using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class SellCodeViewModel
    {
        public List<Sell> Sells { get; set; }
        public List<Product> Products { get; set; }
        public SelectList p_code { get; set; }
        public string Sell_Code { get; set; }
        public string SearchString { get; set; }
    }
}
