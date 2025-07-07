using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про заявки на страхування
    /// </summary>


    [DocumentationContract]
    public partial class InsuranceApplication : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        #region ProtoMember

        /// <summary>
        /// Список страхових продуктів, включених у заявку
        /// </summary>


        [DocumentationMember]
        public List<Product> Products { get; set; }

        /// <summary>
        /// Атрибути об'єкта заявки на страхування, що описують її характеристики та властивості
        /// </summary>


        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }

        /// <summary>
        /// Унікальний ідентифіктор поліса на основі якого створена поточна заявка
        /// </summary>


        [DocumentationMember]
        public Guid? BasedOnProductGID { get; set; }

        #endregion
        #region Cache Details


        private string _InsuranceApplicationSourceTypeName;
        /// <summary>
        /// Метод, що повертає "джерело" заявки
        /// </summary>
        /// <returns>Джерело заявки</returns>

        [DocumentationMember]
        public async Task<string> GetInsuranceApplicationSourceTypeName()
        {
            return _InsuranceApplicationSourceTypeName;
        }

        private string _InsuranceApplicationStatusName;
        /// <summary>
        /// Метод, що повертає статус заявки
        /// </summary>
        /// <returns>Статус заявки</returns>

        [DocumentationMember]
        public async Task<string> GetInsuranceApplicationStatusName()
        {
            return _InsuranceApplicationStatusName;
        }

        #endregion

    }
}