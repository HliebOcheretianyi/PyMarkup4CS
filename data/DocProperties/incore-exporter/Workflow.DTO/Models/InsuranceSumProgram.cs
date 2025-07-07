namespace Workflow.DTO.Models
{



    public partial class InsuranceSumProgram : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid ProgramGID { get; set; }



        public Guid PaymentPeriodGID { get; set; }




        public Decimal? CostValue { get; set; }




        public Decimal? InsuranceRate { get; set; }
    }
}
