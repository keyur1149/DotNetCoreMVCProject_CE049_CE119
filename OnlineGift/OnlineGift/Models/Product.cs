using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Productname")]
        [Required(ErrorMessage ="Product Name is required")]
        public string Name { get; set; }
        [Display(Name = "Productdescription")]
        [Required(ErrorMessage = "Desc is required")]
        public string Desc { get; set; }
        [Required(ErrorMessage = "Product Image is required")]
        public string ImgUrl { get; set; }
        [Display(Name = "Productprize")]
        [Required(ErrorMessage = "Product Prize is required")]
        public int Prize { get; set; }
    }
}
