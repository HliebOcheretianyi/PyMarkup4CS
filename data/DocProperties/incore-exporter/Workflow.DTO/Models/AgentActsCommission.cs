namespace Workflow.DTO.Models
{


    public partial class AgentActsCommission : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid AgentActGID { get; set; }


        public Guid ProductGID { get; set; }


        public string PolisNumber { get; set; }


        public string OriginalPolisNumber { get; set; }


        public string ProductTypeCode { get; set; }


        public Guid ProgramTypeGID { get; set; }


        public string InsuranceTypeCode { get; set; }


        public Guid RealPaymentGID { get; set; }


        public DateTime RealPaymentDate { get; set; }


        public decimal RealPaymentValue { get; set; }


        public DateTime PlanedPaymentDate { get; set; }


        public decimal Value { get; set; }


        public int ValueType { get; set; }


        public decimal CommissionValue { get; set; }


        public Guid OriginalAgentGID { get; set; }


        public Guid? BranchGID { get; set; }


        public Guid? AgentPermissionGID { get; set; }


        public decimal? AgentCommissionValue { get; set; }


        public DateTime? RegisteredDate { get; set; }


        public Guid? InsurerFaceGID { get; set; }
    }
}
