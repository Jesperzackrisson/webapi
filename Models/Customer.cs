using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApi.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CustomerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string PhoneNumber { get; set; }
    }
}

