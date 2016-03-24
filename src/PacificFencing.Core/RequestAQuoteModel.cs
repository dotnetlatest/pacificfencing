using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacificFencing.Core
{
    public class RequestAQuoteModel
    {
        [Required]
        [DisplayName("Contact Name")]
        [StringLength(60,MinimumLength = 3)]
        [DataType(DataType.Text)]
        public string ContactName { get; set; }

        [Required]
        [DisplayName("Street Address")]
        [DataType(DataType.Text)]
        public string AddressLine { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(40,MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [DisplayName("Postal Code")]
        [RegularExpression(@"^\d{5}$|^\d{5}-\d{4}$", ErrorMessage = "The postal code should be in the format 00000 or 00000-0000")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
            
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Description")]
        [StringLength(5000, MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; } 
    }
}
