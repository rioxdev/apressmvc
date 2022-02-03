using System;
using System.ComponentModel.DataAnnotations;

namespace ApressMvc.Models
{
    public class Appointment
    {
        public string ClientName { get; set; }
        [UIHint("Date")]
        public DateTime Date { get; set; }
        public bool TemrsAccepted { get; set; }
            
    }
}
