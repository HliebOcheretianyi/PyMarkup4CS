namespace Workflow.DTO.Models
{


    public partial class AgentReport : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public DateTime? ReportDate { get; set; }



        public Guid? AgentGID { get; set; }


        public Guid? LastModifiedAuthorGID { get; set; }


        public Guid StatusGID { get; set; }



        public Guid? WorkflowGID { get; set; }


        public Guid? CreatorUserGID { get; set; }


        public string CreatorAuthorName { get; set; }


        public string LastModifiedAuthorName { get; set; }


        public string AgentName { get; set; }



        public Face Agent { get; set; }



        public Guid? BranchGID { get; set; }

    }
}