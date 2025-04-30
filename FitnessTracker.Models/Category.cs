using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string AimedBodyPart { get; set; }
        public int DisplayOrder { get; set; }
    }
}
