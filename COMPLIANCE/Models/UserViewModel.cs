using COMPLIANCE.Models.Entities;

namespace COMPLIANCE.Models
{
    public class UserViewModel
    {
        public List<Pages> Pages { get; set; }

        public List<User> Users { get; set; }

        public List<Role> Roles { get; set; }

        public User User { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public List<Permission> Permissions { get; set; }


        public Role Role { get; set; }

        public Pages Page { get; set; }
    }
}
