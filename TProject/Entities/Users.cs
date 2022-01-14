using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Entities
{
    public partial class Users
    {
        public string Id { get; set; }
        public string Account { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Addr { get; set; }
        public string Management { get; set; }
        public bool Active { get; set; }
        public string Pass { get; set; }

        public virtual Authorize AccountNavigation { get; set; }
        public virtual Management ManagementNavigation { get; set; }
    }
}
