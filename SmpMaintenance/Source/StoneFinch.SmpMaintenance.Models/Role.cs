using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoneFinch.SmpMaintenance.Models
{
    [Table("webpages_Roles")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}