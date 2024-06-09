using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDB.Entities
{
    [Table("posts")]
    public class Post
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("name"), Required, MaxLength(100)]
        public string Name { get; set; }

        [Column("description"), Required]
        public string Description { get; set; }

        public Post(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
