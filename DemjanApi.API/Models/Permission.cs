using System.Collections.Generic;

namespace DemjanApi.API.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string NameOfPermission { get; set; }

        public ICollection<UserPermission> UserPermissions { get; } = new List<UserPermission>();

    }
}