using Common.Documentation;
using System.Runtime.Serialization;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про страхові об'єкти
    /// </summary>


    [DocumentationContract]
    public partial class InsuranceObject : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        #region ProtoMember


        public Guid ProgramGID { get; set; }


        public Guid InsuranceObjectTypeGID { get; set; }

        public Guid ObjectTypeGID { get; set; }

        /// <summary>
        /// Страхова сума для об'єкта страхування
        /// </summary>


        [DocumentationMember]
        public Decimal? InsuranceSum { get; set; }

        /// <summary>
        /// Страховий платіж за об'єктом страхування
        /// </summary>


        [DocumentationMember]
        public Decimal? InsurancePayment { get; set; }

        /// <summary>
        /// Страховий тариф для об'єкта страхування
        /// </summary>


        [DocumentationMember]
        public Decimal? InsuranceRate { get; set; }



        public Guid? ObjectGID { get; set; }

        /// <summary>
        /// Назва страхового об'єкта
        /// </summary>


        [DocumentationMember]
        public String Name { get; set; }


        public Decimal? CalculatedInsuranceRate { get; set; }


        public Decimal? CalculatedPayment { get; set; }


        public Guid? ParentInsuranceObjectGID { get; set; }

        /// <summary>
        /// Покриття, що надаються для страхового об'єкта
        /// </summary>


        [DocumentationMember]
        public List<Cover> Covers { get; set; }



        public List<ViolatedUnderwritingRule> ViolatedUnderwritingRules { get; set; }

        /// <summary>
        /// Об'єкт, що Виводить на друк страховий об'єкт
        /// </summary>


        [DocumentationMember]
        public Workflow.DTO.Models.Object Object { get; set; }


        public IEnumerable<Franchise> DefaultFranchises { get; set; }

        /// <summary>
        /// Коефіцієнти, що застосовуються до страхового об'єкта
        /// </summary>


        [DocumentationMember]
        public List<Coefficient> Coefficients { get; set; }




        public List<DocumentsToInsuranceObject> DocumentsToInsuranceObjects { get; set; }

        /// <summary>
        /// Атрибути об'єкта страхування, що описують його характеристики та властивості
        /// </summary>


        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }



        /// <summary>
        /// Курс валют, який використовується для валюти страхової суми
        /// </summary>


        [DocumentationMember]
        public Decimal? CurrencyExchangeCost { get; set; }


        [DataMember]

        public Guid? ObjectVersionGID { get; set; }



        public decimal? BaseInsurancePayment { get; set; }


        public bool? InBaseProduct { get; set; }

        public Guid? DocumentGID { get; set; }
        #endregion
        public Guid? ActualObjectGID
        {
            get
            {
                return ObjectVersionGID ?? ObjectGID;
            }
        }

        private string _InsuranceObjectTypeName;

        [DocumentationMember]
        public async Task<string> GetInsuranceObjectTypeName()
        {
            return _InsuranceObjectTypeName;
        }

        private string _ObjectTypeName;

        [DocumentationMember]
        public async Task<string> GetObjectTypeName()
        {
            return _ObjectTypeName;
        }


        [DocumentationMember]
        public Document GetIdentificationDocument()
        {
            if (DocumentGID.HasValue)
            {
                return Object.Documents.FirstOrDefault(document => document.gid == DocumentGID.Value);
            }

            return null;
        }


    }
}