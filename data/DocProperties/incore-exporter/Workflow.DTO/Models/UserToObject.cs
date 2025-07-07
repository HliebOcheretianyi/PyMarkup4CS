
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Workflow.DTO.Models
{
    
    
    
    public class UserToObject : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        
        
        public Guid UserGID { get; set; }

        
        
        public Guid ObjectGID { get; set; }

        
        
        
        public DateTime Date { get; set; }

        
        
        public Guid? TypeGID { get; set; }
    }
}
