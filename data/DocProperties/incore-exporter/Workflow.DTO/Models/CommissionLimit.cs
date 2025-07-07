namespace Workflow.DTO.Models
{



    public class CommissionLimit : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public decimal? Value { get; set; }




        public DateTime Date { get; set; }



        public Guid ProgramTypeToChanelGID { get; set; }



        public bool Static { get; set; }



        public Guid LimitTypeGID { get; set; }



        public Guid? DocumentGID { get; set; }



        public bool IsAgentAdvance { get; set; }



        public string LimitTypeName { get; set; }



        public string LimitCategoryName { get; set; }



        public Guid? InsuranceTypeGID { get; set; }



        public Guid? ProductTypeGID { get; set; }



        public Guid LimitCategoryGID { get; set; }


        public Guid? AgentGID { get; set; }


        public decimal? BaseValue { get; set; }


        public DateTime? DateTo { get; set; }


        public bool? IsVisible { get; set; }


        public Guid? SalesChannelGID { get; set; }


        public Guid? AgentPermissionGID { get; set; }


        public bool IsLinq { get; set; }


        public Guid? CommissionTypeGID { get; set; }


        public Guid? PartnerAgentGID { get; set; }


        public Guid? CommissionAgentGID { get; set; }


        public Guid? InsuredTypeGID { get; set; }


        public decimal? DefaultValue { get; set; }


        public string CommissionAgentName { get; set; }


        public bool? Brutto { get; set; }
    }
}
