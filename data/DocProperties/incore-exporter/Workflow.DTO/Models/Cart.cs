namespace Workflow.DTO.Models
{



    public partial class Cart : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {



        public string Identifier { get; set; }




        public DateTime CreateDate { get; set; }




        public Guid WorkflowGID { get; set; }




        public List<InsuranceApplication> InsuranceApplications { get; set; }
    }
}
