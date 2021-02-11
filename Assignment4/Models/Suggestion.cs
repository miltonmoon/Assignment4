using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Suggestion
    {
        [Required]
        public string SuggName { get; set; }
        [Required]
        public string SRName { get; set; }
        [Required]
        public string SRFavDish { get; set; }
        [Required]
        [RegularExpression(@"^(1-)?\d{3}-\d{3}-\d{4}$", ErrorMessage = "Must be in Format ###-###-####")]
        public string SRPhone { get; set; }
    }
}
