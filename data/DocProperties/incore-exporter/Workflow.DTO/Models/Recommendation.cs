namespace Workflow.DTO.Models
{


    public class Recommendation : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public string Name { get; set; }



        public string PhoneNumber { get; set; }



        public string Email { get; set; }


        public Guid? StatusGID { get; set; }



        public DateTime? ContactDate { get; set; }



        public string Comment { get; set; }


        public Guid UserToObjectGID { get; set; }



        public string ContractNumber { get; set; }



        public string ContractSerial { get; set; }



        public string ClientRecommendationName { get; set; }



        public Guid? WorkflowGID { get; set; }



        public DateTime? ProlongationDate { get; set; }


    }
}