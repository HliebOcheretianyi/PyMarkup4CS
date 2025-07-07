namespace Workflow.DTO.Models
{


    public partial class AgentApplicationStatusChange : IdentityPersistentEntity
    {


        public Guid AgentApplicationGID { get; set; }



        public Guid StatusGID { get; set; }


        public Guid CreatorUserGID { get; set; }



        public DateTime CreatedDate { get; set; }



        public string Comment { get; set; }


        public string CreatorUserName { get; set; }

    }
}
