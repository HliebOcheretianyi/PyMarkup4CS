using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ProtoBuf;

namespace Workflow.DTO.Models
{
    
    
    public class PartnerProduct : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        
        
        public Guid? SalesPartnerGID { get; set; }

        
        
        public Guid? ProductGID { get; set; }
    }
}
