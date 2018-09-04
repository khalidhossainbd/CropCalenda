using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropCalendar.Models
{
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DivisionName { get; set; }
        [Required]
        public string DiviBbsId { get; set; }
    }
}
