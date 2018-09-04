using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropCalendar.Models
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        public string DistBbsId { get; set; }
        public int ZoneAreaId { get; set; }
        public ZoneArea Zones { get; set; }
        public int DivisionId { get; set; }
        public Division Divisions { get; set; }
    }
}
