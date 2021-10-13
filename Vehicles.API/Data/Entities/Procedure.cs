using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }

        [Display(Name = "Procedure")]
        [MaxLength(50, ErrorMessage = "Field {0} cannot have more than {1} characters.")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public string Description { get; set; }

        [Display(Name = "ThePrice")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public decimal Price { get; set; }


    }
}
