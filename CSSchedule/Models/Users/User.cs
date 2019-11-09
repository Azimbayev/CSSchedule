using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSSchedule.Models.Users
{
    public class User
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [Display(Name = "Username")]
        public string Username { get; set; }
        
        [Display(Name = "User fullname")]
        public string Fullname { get; set; }
        /*
        [Display(Name = "List of events that he created")]
        public string CreatedEvents { get; set; }
        
        [Display(Name = "List of events")]
        public string Events { get; set; }

        [Display(Name = "Event date")]
        public DateTime EventAt { get; set; }
        */
        [Display(Name = "Release date")]
        public DateTime CreatedAt { get; set; }
    }
}
