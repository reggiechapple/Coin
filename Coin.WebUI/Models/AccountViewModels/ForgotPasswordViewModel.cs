﻿using System.ComponentModel.DataAnnotations;

namespace Coin.WebUI.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
