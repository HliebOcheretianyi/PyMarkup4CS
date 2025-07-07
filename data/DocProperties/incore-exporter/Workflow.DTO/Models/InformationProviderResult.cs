namespace Workflow.DTO.Models
{



    public class InformationProviderResult : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public long InformationProviderID { get; set; }



        public long FinMonApplicationID { get; set; }



        public bool? IsPEP { get; set; }



        public bool? IsSanction { get; set; }



        public long? ClientlogID { get; set; }



        public long? CategoryPEPID { get; set; }



        public string JobPEP { get; set; }


        public long? RiskGroupID { get; set; }


        public string RiskGroupReasonDescription { get; set; }


        public bool? IsRussian { get; set; }


        public bool? IsBilorussian { get; set; }


        public bool? IsKBVSanction { get; set; }


        public bool? IsNoProfit { get; set; }
    }
}
