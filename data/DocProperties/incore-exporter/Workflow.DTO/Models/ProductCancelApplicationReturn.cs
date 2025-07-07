using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про повернення по заявках на розірвання продуктів
    /// </summary>


    [DocumentationContract]
    public partial class ProductCancelApplicationReturn : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        /// <summary>
        /// Об'єкт, пов'язаний із поверненням по заявці на розірвання продукту
        /// </summary>


        [DocumentationMember]
        public Object Object { get; set; }

        /// <summary>
        /// Атрибути об'єкта повернення, що описують його характеристики та властивості
        /// </summary>


        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }


        /// <summary>
        /// Сума повернення по заявці на розірвання продукту
        /// </summary>


        [DocumentationMember]
        public Decimal ReturnSum { get; set; }


        private string _ReturnTypeCaption;

        [DocumentationMember]
        public async Task<string> GetReturnTypeCaption()
        {
            return _ReturnTypeCaption;
        }
    }
}