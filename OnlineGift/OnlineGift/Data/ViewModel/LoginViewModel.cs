using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Data.ViewModel
{
    public class LoginViewModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
    }
}
