using System.ComponentModel.DataAnnotations;

namespace StoneFinch.SmpMaintenance.Models
{
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
    }
}