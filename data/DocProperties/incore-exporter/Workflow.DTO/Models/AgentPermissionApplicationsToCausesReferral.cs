namespace Workflow.DTO.Models
{



    public class AgentPermissionApplicationsToCausesReferral : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public Guid AgentPermissionApplicationGID { get; set; }



        public Guid CausesReferralGID { get; set; }



        public CausesReferral CausesReferral { get; set; }
    }
}
