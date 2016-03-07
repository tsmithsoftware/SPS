using System;
using ADOv2.Interfaces;

namespace ADOv2.Models
{
    public partial class ServicesProvided:IEntity
    {
        public int LinkId { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Service Service { get; set; }

        public int Id
        {
            get { return LinkId; }
        }
    }
}
