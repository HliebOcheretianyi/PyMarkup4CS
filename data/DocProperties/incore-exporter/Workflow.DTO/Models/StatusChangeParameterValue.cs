namespace Workflow.DTO.Models
{


    public partial class StatusChangeParameterValue : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public Guid StatusChangeGID { get; set; }


        public Guid StatusParameterGID { get; set; }


    }
}