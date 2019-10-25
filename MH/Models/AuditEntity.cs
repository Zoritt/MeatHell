using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH.Models
{
    public class AuditEntity
    {
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
