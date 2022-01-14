using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Entities
{
    public partial class Owner
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Management { get; set; }
        public string Rfid { get; set; }
        public bool Quit { get; set; }

        public virtual Management ManagementNavigation { get; set; }
    }
}
