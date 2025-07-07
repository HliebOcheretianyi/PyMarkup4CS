
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.DTO.Models
{
    
    
    public class FinMonProcess : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        
        
        public string ProcessID { get; set; }
        
        
        public long? ProcessTypeID { get; set; }
        
        
        public int Hash { get; set; }
        
        
        public string Details { get; set; }
        
        
        public DateTime CreateDate { get; set; }
    }
}
