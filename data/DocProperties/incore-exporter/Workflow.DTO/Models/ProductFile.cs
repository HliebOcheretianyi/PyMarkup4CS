
using ProtoBuf;
using System;

namespace Workflow.DTO.Models
{
    

    
    public partial class ProductFile : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        
        public Guid EntityGID { get; set; }


        
        public Guid FileGID { get; set; }

        

        
        public String Name { get; set; }

        

        
        public String Description { get; set; }


        
        public Guid TypeGID { get; set; }


        
        public Guid SourceTypeGID { get; set; }

        
        public bool Signed { get; set; }

        
        public Guid? ProductGID { get; set; }

        
        public bool IsHidden { get; set; }
    }
}