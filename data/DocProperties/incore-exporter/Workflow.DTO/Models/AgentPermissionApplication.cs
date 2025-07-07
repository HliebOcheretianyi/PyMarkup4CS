namespace Workflow.DTO.Models
{


    public class AgentPermissionApplication : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public Guid StatusGID { get; set; }


        public Guid CreaterUserGID { get; set; }


        public string Comment { get; set; }



        public Guid? WorkflowGID { get; set; }


        public Guid? ForumGID { get; set; }


        public DateTime CreateDate { get; set; }


        public string CreatorUserName { get; set; }



        public Guid? AgentPermissionGID { get; set; }


        public string TariffComment { get; set; }


        public DateTime? StartDate { get; set; }



        public DateTime? EndDate { get; set; }


        public Guid? TariffScaleGID { get; set; }


        public Guid? ProductTypeGID { get; set; }



        public DateTime? AgreedDate { get; set; }


        public decimal? ExpectedPayments { get; set; }


        public Guid? ProductTypeScopeGID { get; set; }


        public string ProductTypeScopeName { get; set; }


        public List<AgentPermissionApplicationToAgent> AgentPermissionApplicationToAgents { get; set; }


        public List<AgentPermissionApplicationsToCausesReferral> AgentPermissionApplicationsToCausesReferrals { get; set; }


        public List<AgentPermissionApplicationCommissionLimit> AgentPermissionApplicationCommissionLimits { get; set; }


        public string ChanelName { get; set; }


        public string ProductTypeScopeCode { get; set; }


        public string BranchName { get; set; }


        public Guid? PersonGID { get; set; }


        public AgentPermission AgentPermission { get; set; }



        public Guid? AgreedGID { get; set; }



        public Guid? CancelationReasonGID { get; set; }


        public string AgentPermissionNumber { get; set; }



        public Guid? PaymentReimbursementGID { get; set; }
        public ForumPost[] ForumPosts { get; set; }
        public string AgreedUserName { get; set; }

        private string _StatusName;

    }
}