using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_ASP_CORE_CRUD.Models
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Full Name")]
        public string CodeName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Car Code Name")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Engine HP")]
        public int Hp { get; set; }


    }
}
