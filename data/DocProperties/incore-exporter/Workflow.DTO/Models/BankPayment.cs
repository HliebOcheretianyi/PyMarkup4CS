namespace Workflow.DTO.Models
{



    public class BankPayment : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {



        public DateTime PaymentDate { get; set; }




        public decimal Value { get; set; }



        public Guid CurrencyGID { get; set; }




        public string Comment { get; set; }



        public Guid BranchGID { get; set; }

        public decimal Return { get; set; }
    }
}
