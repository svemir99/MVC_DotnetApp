using FirstMvcApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirsttMvcApps.Models
{
    public partial class Person
    {
        public int Id { get; set; }

        [Display(Name = "First name")]

        [Required(ErrorMessage ="Please enter you first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]

        [Required(ErrorMessage = "Please enter you last name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]

        [Required(ErrorMessage = "Please enter you date of birth")]

        [DateRange(From = "1880/01/01", To = "2016/03/03", ErrorMessage = "Date of birth is not in given range")]

        public DateTime DateOfBirth { get; set; }

        public int? IsDeleted { get; set; }
    }
}
