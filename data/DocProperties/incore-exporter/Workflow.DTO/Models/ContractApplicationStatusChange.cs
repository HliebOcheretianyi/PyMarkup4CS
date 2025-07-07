namespace Workflow.DTO.Models
{


    public partial class ContractApplicationStatusChange : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public Guid ContractApplicationGID { get; set; }



        public Guid StatusGID { get; set; }


        public Guid CreatorUserGID { get; set; }



        public DateTime CreatedDate { get; set; }



        public List<ContractApplicationStatusChangeParameterValue> ContractApplicationStatusChangeParameterValues { get; set; }



        public string Comment { get; set; }


        public string CreatorUserName { get; set; }

    }
}