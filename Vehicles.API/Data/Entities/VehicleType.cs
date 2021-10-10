using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class VehicleType
    {
        public int Id { get; set; }

        [Display(Name ="Vehicle Type")]
        [MaxLength(50, ErrorMessage = "Field {0} cannot have more than {1} characters.")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public string Description { get; set; }
    }
}
