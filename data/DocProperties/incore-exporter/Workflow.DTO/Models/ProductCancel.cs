using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про розірвання продуктів
    /// </summary>


    [DocumentationContract]
    public partial class ProductCancel : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid ProductCancelTypeGID { get; set; }

        /// <summary>
        /// Атрибути об'єкта розірвання продукту, що описують його характеристики та властивості
        /// </summary>
        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }


        private string _ProductCancelTypeName;

        [DocumentationMember]
        public async Task<string> GetProductCancelTypeName()
        {
            return _ProductCancelTypeName;
        }
    }
}