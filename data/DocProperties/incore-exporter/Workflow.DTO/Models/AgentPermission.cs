namespace Workflow.DTO.Models
{


    public class AgentPermission : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public DateTime StartDate { get; set; }


        public DateTime? EndDate { get; set; }


        public bool IsAutoProlonged { get; set; }


        public Guid? CreaterUserGID { get; set; }


        public string TariffScaleName { get; set; }


        public DateTime CreateDate { get; set; }


        public Guid? ProductTypeGID { get; set; }


        public Guid? ProductTypeScopeGID { get; set; }


        public string ProductTypeScopeName { get; set; }


        public List<CommissionLimit> CommissionLimits { get; set; }


        public string Number { get; set; }


        public Guid? TariffScaleGID { get; set; }


        public string ProductTypeScopeCode { get; set; }


        public string CreatorUserName { get; set; }


        public Guid? PersonGID { get; set; }


        public Guid? SalesChannelGID { get; set; }


        public List<Branch> Branches { get; set; }


        public List<Face> Agents { get; set; }


        public List<AgentChannel> AgentChannels { get; set; }



        public List<EntityAttribute> EntityAttributes { get; set; }


        public string Comment { get; set; }


        public List<AgentChannel> Channels { get; set; }


        public string Code { get; set; }

    }
}