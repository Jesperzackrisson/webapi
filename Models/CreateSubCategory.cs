using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApi.Models
{
    public class CreateSubCategory
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
