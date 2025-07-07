namespace Workflow.DTO.Models
{



    public class AgentPermissionToAgent : Workflow.DTO.Models.IdentityPersistentEntity
    {



        public Guid AgentGID { get; set; }




        public Guid AgentPermissionGID { get; set; }




        public Guid ChannelGID { get; set; }
    }
}
