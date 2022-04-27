using System.ComponentModel.DataAnnotations;

namespace APITalycap.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }
        public int IdBook { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
