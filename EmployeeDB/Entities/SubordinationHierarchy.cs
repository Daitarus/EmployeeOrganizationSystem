using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDB.Entities
{
    [Table("subordination_hierarchies")]
    public class SubordinationHierarchy
    {
        [Column("employee_id"), Required]
        public Guid EmployeeId { get; set; }

        [Column("post_id"), Required]
        public Guid PostId { get; set; }

        public SubordinationHierarchy(Guid employeeId, Guid postId)
        {
            EmployeeId = employeeId;
            PostId = postId;
        }
    }
}
