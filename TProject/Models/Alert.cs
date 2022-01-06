using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class Alert
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Alevel { get; set; }
        public string Management { get; set; }

        public virtual Management ManagementNavigation { get; set; }
    }
}
