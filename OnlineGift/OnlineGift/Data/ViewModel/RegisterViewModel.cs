using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Data.ViewModel
{
    public class RegisterViewModel
    {

        [Key]
        public int U_id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
    }
}
