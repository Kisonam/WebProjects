using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPPractice.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="U must wright your name!")] 
        public string Name { get; set; }
    }
}
