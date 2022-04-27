using System.ComponentModel.DataAnnotations;

namespace APITalycap.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PageCount { get; set; }
        public string Excerpt { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
