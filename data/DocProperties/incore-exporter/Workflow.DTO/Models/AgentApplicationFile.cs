namespace Workflow.DTO.Models
{


    public partial class AgentApplicationFile : IdentityDeletedPersistentEntity
    {

        public Guid EntityGID { get; set; }


        public Guid FileGID { get; set; }



        public String Name { get; set; }



        public String Description { get; set; }


        public Guid TypeGID { get; set; }


        public bool Signed { get; set; }


        public Guid? AgentApplicationGID { get; set; }
    }
}
