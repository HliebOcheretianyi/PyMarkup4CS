using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про програми
    /// </summary>


    [DocumentationContract]
    public partial class Program : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        #region ProtoMember
        public Guid ProgramTypeGID { get; set; }

        /// <summary>
        /// Страхова сума по програмі
        /// </summary>


        [DocumentationMember]
        public Decimal CostValue { get; set; }

        /// <summary>
        /// Розрахована сума платежу по програмі
        /// </summary>

        [DocumentationMember]
        public Decimal? CalculatedPayment { get; set; }

        /// <summary>
        /// Коефіцієнти, що застосовуються в програмі
        /// </summary>


        [DocumentationMember]
        public List<Coefficient> Coefficients { get; set; }

        /// <summary>
        /// Комісії, пов'язані з програмою
        /// </summary>


        [DocumentationMember]
        public List<Commission> Commissions { get; set; }

        /// <summary>
        /// Страхові об'єкти, пов'язані з програмою
        /// </summary>


        [DocumentationMember]
        public List<InsuranceObject> InsuranceObjects { get; set; }


        /// <summary>
        /// Параметри програми
        /// </summary>


        [DocumentationMember]
        public List<ProgramParameterValue> Parameters { get; set; }

        /// <summary>
        /// Порушені правила андерайтингу в програмі
        /// </summary>


        [DocumentationMember]
        public List<ViolatedUnderwritingRule> ViolatedUnderwritingRules { get; set; }


        /// <summary>
        /// Дата початку дії програми
        /// </summary>

        [DocumentationMember]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Дата закінчення дії програми
        /// </summary>

        [DocumentationMember]
        public DateTime? DateTo { get; set; }

        #endregion
        #region Cache Details
        private string _ProgramTypeName;

        [DocumentationMember]
        public async Task<string> GetProgramTypeName()
        {
            return _ProgramTypeName;
        }


        private string _InsuranceTypeCode;

        [DocumentationMember]
        public async Task<string> GetInsuranceTypeCode()
        {
            return _InsuranceTypeCode;
        }
        #endregion
    }
}