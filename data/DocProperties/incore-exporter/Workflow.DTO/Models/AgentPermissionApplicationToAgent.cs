namespace Workflow.DTO.Models
{



    public class AgentPermissionApplicationToAgent : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public Guid AgentPermissionApplicationGID { get; set; }



        public Guid AgentGID { get; set; }



        public string AgentName { get; set; }



        public string BranchName { get; set; }



        public string ChanelName { get; set; }
    }
}
