using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Entities
{
    public partial class AuGroup
    {
        public AuGroup()
        {
            Authorize = new HashSet<Authorize>();
        }

        public string Aname { get; set; }
        public string Info { get; set; }

        public virtual ICollection<Authorize> Authorize { get; set; }
    }
}
