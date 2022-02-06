using System;
using System.ComponentModel.DataAnnotations;

namespace ApressMvc.Models
{
    public class Appointment
    {
        [Required]
        [MaxLength(15)]
        public string ClientName { get; set; }
        [UIHint("Date")]
        public DateTime Date { get; set; }
        [Required]
        public bool TemrsAccepted { get; set; }
            
    }
}
