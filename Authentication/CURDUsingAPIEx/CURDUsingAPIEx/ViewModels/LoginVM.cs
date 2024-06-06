using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CURDUsingAPIEx.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage="Email ID Required")]
        [EmailAddress(ErrorMessage="Invalid Email ID")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
