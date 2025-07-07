namespace Workflow.DTO.Models
{

    public partial class InsuranceApplicationOperation : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid InsuranceApplicationGID { get; set; }


        public DateTime? Date { get; set; }


        public string Operation { get; set; }


        public string Description { get; set; }
    }
}