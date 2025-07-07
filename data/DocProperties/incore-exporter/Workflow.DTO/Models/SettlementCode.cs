namespace Workflow.DTO.Models
{


    public class SettlementCode : IdentityDeletedPersistentEntity
    {


        public Guid SettlementGID { get; set; }



        public string Code { get; set; }
    }
}
