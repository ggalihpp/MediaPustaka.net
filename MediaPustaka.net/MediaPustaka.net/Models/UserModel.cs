using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaPustaka.net.Models
{
    [MetadataType(typeof(UserMetadata))]
    public class UserModel
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string EmailID { get; set; }
        public Boolean Status { get; set; }
    }

    public class UserMetadata
    {
        [Display(Name = "Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is  mandatory")]
        public string username { get; set; }

        [Display(Name = "Email Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Address is  mandatory")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please insert correct email")]
        public string EmailID { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is  mandatory")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum Character is 6")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not Match!")]
        public string ConfirmPassword { get; set; }
    }
}