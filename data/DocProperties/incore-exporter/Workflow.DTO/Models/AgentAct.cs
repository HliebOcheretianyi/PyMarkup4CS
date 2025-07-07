namespace Workflow.DTO.Models
{


    public partial class AgentAct : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid AgentGID { get; set; }


        public Guid StatusGID { get; set; }


        public Guid ChanelGID { get; set; }


        public Guid CommissionTypeGID { get; set; }


        public DateTime StartPeriod { get; set; }


        public DateTime EndPeriod { get; set; }



        public Guid? WorkflowGID { get; set; }


        public Guid? SignTypeGID { get; set; }



        public DateTime? ApprovedDate { get; set; }

    }
}