using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class Authorize
    {
        public Authorize()
        {
            Users = new HashSet<Users>();
        }

        public string Account { get; set; }
        public string Name { get; set; }
        public string Aname { get; set; }

        public virtual AuGroup AnameNavigation { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
