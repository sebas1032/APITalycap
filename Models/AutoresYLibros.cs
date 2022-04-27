using System.ComponentModel.DataAnnotations;

namespace APITalycap.Models
{
    public class AutoresYLibros
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PageCount { get; set; }
        public string Excerpt { get; set; }
        public DateTime PublishDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}