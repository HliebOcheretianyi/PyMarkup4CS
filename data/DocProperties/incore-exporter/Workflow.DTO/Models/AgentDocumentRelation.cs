namespace Workflow.DTO.Models
{


    public class AgentDocumentRelation : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid DocumentGID { get; set; }


        public Guid AgentGID { get; set; }



        public DateTime? DateFrom { get; set; }



        public DateTime? DateTo { get; set; }


        public DateTime CreateDate { get; set; }


        public Guid CreatorUserGID { get; set; }
    }
}
