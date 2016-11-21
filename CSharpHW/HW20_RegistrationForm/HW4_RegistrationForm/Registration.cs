﻿
using System.ComponentModel.DataAnnotations;

namespace HW4_RegistrationForm
{
    class Registration
    {
        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = @"Use letters please for FirstName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = @"Use letters please for LastName")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d", ErrorMessage = @"not  correct date")]
        public string BirthDay { get; set; }

        [Required]
        [RegularExpression(@"^male|female$", ErrorMessage = @"male or female only")]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = @"not correct email")]
        public string Email { get; set; }

        [Required]
        [StringLength(12)]
        [MinLength(12)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = @"Use numbers please for phone number")]
        public string PhoneNumber { get; set; }

        [StringLength(1000)]
        public string AdditionalInfo { get; set; }
    }
}
