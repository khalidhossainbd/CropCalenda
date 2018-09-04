using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropCalendar.Models
{
    public class ZoneArea
    {
        [Key]
        public int ZoneId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ZoneName { get; set; }
        [Required]
        public string ZoneBbsId { get; set; }
    }
}
