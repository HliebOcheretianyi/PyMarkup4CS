namespace Workflow.DTO.Models
{



    public class AgentPermissionApplicationCommissionLimit : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public decimal Value { get; set; }



        public DateTime? Date { get; set; }



        public Guid AgentPermissionApplicationGID { get; set; }



        public Guid LimitTypeGID { get; set; }



        public string LimitTypeName { get; set; }



        public string LimitCategoryName { get; set; }



        public bool Brutto { get; set; }
    }
}
