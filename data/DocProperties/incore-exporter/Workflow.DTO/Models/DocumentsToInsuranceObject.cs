namespace Workflow.DTO.Models
{



    public partial class DocumentsToInsuranceObject : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid InsuranceObjectGID { get; set; }



        public Guid DocumentGID { get; set; }
    }
}
