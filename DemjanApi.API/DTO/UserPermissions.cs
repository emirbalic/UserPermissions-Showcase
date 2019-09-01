using System.Collections;
using System.Collections.Generic;
using DemjanApi.API.Models;

namespace DemjanApi.API.DTO
{
    public class UserPermissions
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public ICollection<UserPermission> Permissions { get; set; }
    }
}