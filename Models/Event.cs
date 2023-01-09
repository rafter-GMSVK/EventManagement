using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Event 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EventLocation { get; set; } = "Not provided";
        
        public DateTime EventDateTime { get; set; } = DateTime.Now;

        public string OrganizerName { get; set; } = "Not provided";

        public Event()
        {

        }
    }
}
