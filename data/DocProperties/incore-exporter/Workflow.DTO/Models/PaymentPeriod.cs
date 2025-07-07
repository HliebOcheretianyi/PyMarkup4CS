using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про платіжні періоди
    /// </summary>


    [DocumentationContract]
    public partial class PaymentPeriod : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid ProductGID { get; set; }

        /// <summary>
        /// Запланована дата платежу в межах періоду
        /// </summary>


        [DocumentationMember]
        public DateTime PlanDate { get; set; }

        /// <summary>
        /// Дата закінчення дії платіжного періоду
        /// </summary>


        [DocumentationMember]
        public DateTime DueDate { get; set; }



        public String MFO { get; set; }



        public String TicketNumber { get; set; }



        public DateTime? Date { get; set; }



        public Decimal? Sum { get; set; }

        /// <summary>
        /// Дата початку дії платіжного періоду
        /// </summary>


        [DocumentationMember]
        public DateTime? StartDate { get; set; }


        public Boolean IsAdditional { get; set; }

        /// <summary>
        /// Список запланованих платежів в межах періоду
        /// </summary>


        [DocumentationMember]
        public List<PlanedPayment> PlanedPayments { get; set; }



        public List<InsuranceSumInsuranceObject> InsuranceSumInsuranceObjects { get; set; }



        public List<InsuranceSumProgram> InsuranceSumPrograms { get; set; }

    }
}