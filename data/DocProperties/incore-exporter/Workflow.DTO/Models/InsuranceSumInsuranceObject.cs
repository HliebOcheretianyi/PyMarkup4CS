namespace Workflow.DTO.Models
{



    public partial class InsuranceSumInsuranceObject : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid InsuranceObjectGID { get; set; }



        public Guid PaymentPeriodGID { get; set; }




        public Decimal? InsuranceSum { get; set; }




        public Decimal? InsuranceRate { get; set; }




        public Decimal? InsurancePayment { get; set; }
    }
}
