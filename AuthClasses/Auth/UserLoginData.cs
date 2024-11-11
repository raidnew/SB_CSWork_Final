﻿using System.ComponentModel.DataAnnotations;

namespace CSWork21.Auth
{
    public class UserLoginData
    {
        [Required, MaxLength(32)] 
        public string UserName { get; set; }
        
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
