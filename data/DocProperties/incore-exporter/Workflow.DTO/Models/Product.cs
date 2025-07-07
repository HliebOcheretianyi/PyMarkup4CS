using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про продукти
    /// </summary>


    [DocumentationContract]
    public partial class Product : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        #region ProtoMember

        public Guid ProductTypeGID { get; set; }

        /// <summary>
        /// Номер полісу
        /// </summary>


        [DocumentationMember]
        public String PolisNumber { get; set; }

        /// <summary>
        /// Унікальний ідентифікатор відділення продажу полісу
        /// </summary>


        [DocumentationMember]
        public Guid BranchGID { get; set; }


        /// <summary>
        /// Дата початку дії продукту
        /// </summary>


        [DocumentationMember]
        public DateTime BeginingDate { get; set; }

        /// <summary>
        /// Дата завершення дії продукту
        /// </summary>


        [DocumentationMember]
        public DateTime EndingDate { get; set; }

        /// <summary>
        /// Дата реєстрації продукту
        /// </summary>


        [DocumentationMember]
        public DateTime RegisteredDate { get; set; }



        /// <summary>
        /// Номер звіту агента, пов'язаного з продуктом
        /// </summary>


        [DocumentationMember]
        public String AgentReportNumber { get; set; }


        /// <summary>
        /// Страхова сума продукту в національній валюті
        /// </summary>


        [DocumentationMember]
        public Decimal? InsuranceSumUkr { get; set; }

        /// <summary>
        /// Додаткові коментарі або примітки до продукту
        /// </summary>

        [DocumentationMember]
        public String Comment { get; set; }


        /// <summary>
        /// Дата створення продукту
        /// </summary>


        [DocumentationMember]
        public DateTime? CreateDate { get; set; }


        /// <summary>
        /// Список бланків, пов'язаних з продуктом
        /// </summary>


        [DocumentationMember]
        public List<Blank> Blanks { get; set; }


        /// <summary>
        /// Платіжні періоди, пов'язані з продуктом
        /// </summary>


        [DocumentationMember]
        public List<PaymentPeriod> PaymentPeriods { get; set; }


        /// <summary>
        /// Програми, пов'язані з продуктом
        /// </summary>


        [DocumentationMember]
        public List<Program> Programs { get; set; }

        /// <summary>
        /// Генеральний договір, пов'язаний з продуктом
        /// </summary>


        [DocumentationMember]
        public Contract Contract { get; set; }

        /// <summary>
        /// Страховик, пов'язаний з продуктом
        /// </summary>


        [DocumentationMember]
        public Signer Insurer { get; set; }

        /// <summary>
        /// Відповідальна особа за продукт
        /// </summary>


        [DocumentationMember]
        public Signer Responsible { get; set; }

        /// <summary>
        /// Атрибути об'єкта продукту, що описують його характеристики та властивості
        /// </summary>


        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }


        /// <summary>
        /// Дата початку дії оригінального продукту
        /// </summary>


        [DocumentationMember]
        public DateTime? OriginalProductBeginingDate { get; set; }
        public Guid? SalesChannelGID { get; set; }
        public Guid? SubSalesChannelGID { get; set; }
        public Guid? SupplementaryAgreementTypeGID { get; set; }


        #endregion


        #region Cache Details

        private string _BranchName;

        [DocumentationMember]
        public async Task<string> GetBranchName()
        {
            return _BranchName;
        }

        private string _BranchCode;

        [DocumentationMember]
        public async Task<string> GetBranchCode()
        {
            return _BranchCode;
        }


        private string _ProductTypeName;

        [DocumentationMember]
        public async Task<string> GetProductTypeName()
        {
            return _ProductTypeName;
        }

        private string _ProductTypeCode;

        [DocumentationMember]
        public async Task<string> GetProductTypeCode()
        {
            return _ProductTypeCode;
        }

        private string _SalesChannelName;

        [DocumentationMember]
        public async Task<string> GetSalesChannelName()
        {
            return _SalesChannelName;
        }


        private string _SubSalesChannelName;

        [DocumentationMember]
        public async Task<string> GetSubSalesChannelName()
        {
            return _SubSalesChannelName;
        }
        private string _SupplementaryAgreementTypeName;

        [DocumentationMember]
        public async Task<string> GetSupplementaryAgreementTypeName()
        {
            return _SupplementaryAgreementTypeName;
        }

        #endregion

    }
}