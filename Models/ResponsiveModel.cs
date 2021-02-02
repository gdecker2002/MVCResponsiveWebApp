using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MVCResponsiveWebApp.Models
{
    public class ResponsiveModel
    {
        public string userName { get; set; }
        [Required(ErrorMessage = "Please enter a 4 digit number.")]
        [Range(1900, 2021, ErrorMessage = "Number of years must be between 1900 and 2021.")]
        public int? yearOfBirth { get; set; }
        public int AgeThisYear()
        {
            int _CURRENTYEAR = 2021;
            int age = _CURRENTYEAR - yearOfBirth.Value;
            return age;
        }
        

    }
}
