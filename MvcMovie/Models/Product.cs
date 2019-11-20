using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "품목코드")]
        public string p_code { get; set; }

        [Required]
        [Display(Name = "품목명")]
        public string p_name { get; set; }
        [Required]
        [Display(Name = "사이즈")]
        public int p_measure { get; set; }
      
        [Required]
        [Display(Name = "수량")]
        public int p_many { get; set; }
        [Required]
        [Display(Name = "공급가")]
        public int p_comprice { get; set; }
        [Required]
        [Display(Name = "소비자가격_정가")]
        public int p_customerprice { get; set; }
        [Required]
        [Display(Name = "창고위치")]
        public string p_location { get; set; }
        [Required]
        [Display(Name = "단위")]
        public string p_amount { get; set; }
        [Required]
        [Display(Name = "브랜드")]
        public string p_brandname { get; set; }
       
        [ForeignKey("p_name")]
        public List<Sell> Sell { get; set; }
    }
}
