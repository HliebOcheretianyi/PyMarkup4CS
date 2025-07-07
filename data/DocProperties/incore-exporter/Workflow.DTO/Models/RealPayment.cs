using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про реальні платежі
    /// </summary>


    [DocumentationContract]
    public partial class RealPayment : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        /// <summary>
        /// Дата здійснення реального платежу
        /// </summary>


        [DocumentationMember]
        public DateTime PaymentDate { get; set; }



        public Decimal Value { get; set; }


        public String Comment { get; set; }


        public Boolean IsCommission { get; set; }


        public Boolean IsAutomatic { get; set; }


        public Guid SourceTypeGID { get; set; }
    }
}