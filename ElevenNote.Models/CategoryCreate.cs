using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Please enter at least 2 characters")]
        [MaxLength(40, ErrorMessage ="there are too many characters")]
        public string Name { get; set; }

    }
}
