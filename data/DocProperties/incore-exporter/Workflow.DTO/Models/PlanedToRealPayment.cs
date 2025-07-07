using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про здійснені платежі
    /// </summary>


    [DocumentationContract]
    public partial class PlanedToRealPayment : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid PlanedPaymentGID { get; set; }


        public Guid RealPaymentGID { get; set; }

        /// <summary>
        /// Величина здійсненого платежу
        /// </summary>


        [DocumentationMember]
        public Decimal Value { get; set; }

        /// <summary>
        /// Інформація про реальний платіж, здійснений за планом
        /// </summary>


        [DocumentationMember]
        public RealPayment RealPayment { get; set; }
    }
}