namespace Workflow.DTO.Models
{



    public class ContractApplicationObject
    {



        public Guid ContractApplicationGID { get; set; }




        public Guid ObjectGID { get; set; }




        public Guid InsuranceObjectTypeGID { get; set; }




        public Guid ObjectTypeGID { get; set; }




        public Workflow.DTO.Models.Object Object { get; set; }




        public string ErrorMessage { get; set; }




        public List<InsuranceObject> InsuranceObjects { get; set; }
    }
}
