using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про заявки на розірвання продуктів
    /// </summary>


    [DocumentationContract]
    public partial class ProductCancelApplication : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        /// <summary>
        /// Дата розірвання продукту
        /// </summary>


        [DocumentationMember]
        public DateTime CancelDate { get; set; }

        /// <summary>
        /// Сума на ведення справи
        /// </summary>


        [DocumentationMember]
        public Decimal OnDealSum { get; set; }

        /// <summary>
        /// Сума повернення по заявці на розірвання продукту
        /// </summary>


        [DocumentationMember]
        public Decimal ReturnSum { get; set; }


        /// <summary>
        /// Атрибути об'єкта заявки на розірвання продукту, що описують його характеристики та властивості
        /// </summary>


        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }


        /// <summary>
        /// Номер полісу продукту
        /// </summary>


        [DocumentationMember]
        public string PolisNumber { get; set; }


        /// <summary>
        /// Список повернень, пов'язаних із заявкою на розірвання продукту
        /// </summary>


        [DocumentationMember]
        public List<ProductCancelApplicationReturn> ProductCancelApplicationReturns { get; set; }

        /// <summary>
        /// Дата початку дії продукту
        /// </summary>

        [DocumentationMember]
        public DateTime ProductBeginingDate { get; set; }

        /// <summary>
        /// Дата завершення дії продукту
        /// </summary>

        [DocumentationMember]
        public DateTime ProductEndingDate { get; set; }



        /// <summary>
        /// Оригінальний номер полісу продукту
        /// </summary>


        [DocumentationMember]
        public string OriginalPolisNumber { get; set; }


        [DocumentationMember]
        public Decimal UsedSum { get; set; }


    }
}