using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class MenuMaster
    {
        [Key]
        public int Id { get; set; }

        public string MenuName { get; set; }

        public string MenuURL { get; set; }

    }
}
