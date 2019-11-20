using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Sell
    {
        [Key]
        [Display(Name = "판매코드")]
        public string s_code { get; set; }
        
        [Display(Name = "제품명")]
        public string p_name { get; set; }

        [Display(Name = "판매날짜")]
        [DataType(DataType.Date)]
        public DateTime SellDate { get; set; }

        [Required]
        [Display(Name = "수량")]
        public int s_amount { get; set; }

        [Required]
        [Display(Name = "판매가격")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "마진율")]
        public string Rating { get; set; }
        public Product Product { get; set; }
    }
}

