using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDB.Entities
{
    [Table("employees")]
    public class Employee
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("name"), Required, MaxLength(100)]
        public string Name { get; set; }

        [Column("post_id")]
        public Guid? PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post? Post { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public Employee(string name, Guid postId)
        {
            Name = name;
            PostId = postId;
        }
    }
}
