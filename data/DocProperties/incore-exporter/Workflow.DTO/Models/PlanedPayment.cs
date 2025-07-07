using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про заплановані платежі
    /// </summary>


    [DocumentationContract]
    public partial class PlanedPayment : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid ProgramGID { get; set; }



        public Guid PaymentPeriodGID { get; set; }

        /// <summary>
        /// Величина запланованого платежу
        /// </summary>


        [DocumentationMember]
        public Decimal Value { get; set; }

        /// <summary>
        /// Список реальних платежів, здійснених за запланованими платежами
        /// </summary>


        [DocumentationMember]
        public List<PlanedToRealPayment> PlanedToRealPayments { get; set; }



        public string ProgramTypeCaption { get; set; }


        public decimal UnPaid
        {
            get
            {
                return Value - (PlanedToRealPayments != null ? PlanedToRealPayments.Sum(p => p.Value) : 0);
            }
        }

        public decimal NotPaidSum { get; set; }
        public int InsuranceApplicationID { get; set; }
        public Guid ProductTypeGID { get; set; }
        public DateTime PlanDate { get; set; }
        public Guid InsurerGID { get; set; }


        public Guid? CurrencyGID { get; set; }


        public decimal? CurrencyExchangeCost { get; set; }
    }
}