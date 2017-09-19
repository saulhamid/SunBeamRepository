using SunBeam.Common.Utility;
using System;

namespace SunBeam.Domain
{
    public class BaseEntity
    {
        public string Remarks { get; set; }
        public Nullable<bool> IsActive { get; set; } = true;
        public Nullable<bool> IsArchive { get; set; } = false;
        public string CreatedBy { get; set; }  
        public string CreatedAt { get; set; }
        public string CreatedFrom { get; set; }
        public string LastUpdateBy { get; set; }
        public string LastUpdateAt { get; set; }
        public string LastUpdateFrom { get; set; }
    }
}
