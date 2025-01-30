using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public class Server
    {
        public Server() 
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 2);
            IsOnline = random == 0 ? false : true;
        }

        public int Id { get; set; }
        public bool IsOnline { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
    }
}
