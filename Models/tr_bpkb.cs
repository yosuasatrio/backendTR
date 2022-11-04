using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backendTR.Models
{
    public class ms_storage_location
    {
        [Key]
        public string location_id { get; set; }
        public string location_name { get; set; }
    }
}
