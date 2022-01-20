using System.ComponentModel.DataAnnotations;
namespace Writer.Shared
{
    public class Message
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Sent { get; set; }
        [Required]
        public DateTime Recieved { get; set; }
    }
}