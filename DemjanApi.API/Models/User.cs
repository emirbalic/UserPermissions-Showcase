using System.Collections.Generic;

namespace DemjanApi.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public ICollection<UserPermission> UserPermissions { get; } = new List<UserPermission>();

    }
}