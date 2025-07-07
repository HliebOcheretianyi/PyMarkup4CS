using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using ProtoBuf;

namespace Workflow.DTO.Models
{
    
    
    
    public class ForumTopic : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        
        
        
        public string Name { get; set; }

        
        
        public Guid CategoryGID { get; set; }

        
        
        public Guid ApplicationGID { get; set; }

        
        
        
        public List<ForumPost> ForumPosts { get; set; }
    }
}
