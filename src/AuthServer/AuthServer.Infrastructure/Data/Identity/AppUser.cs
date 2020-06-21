using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServer.Infrastructure.Data.Identity
{
    public class AppUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
