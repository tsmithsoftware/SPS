using System;
using System.Collections.Generic;

namespace ADO.Models
{
    public partial class ServicesProvided
    {
        public int LinkId { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Service Service { get; set; }
    }
}
