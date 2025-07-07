using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про акти
    /// </summary>


    [DocumentationContract]
    public partial class Act : Workflow.DTO.Models.IdentityPersistentEntity
    {
        /// <summary>
        /// Список інтервалів бланків, які використовуються в акті для позначення початкових і кінцевих значень діапазонів бланків
        /// </summary>
        [DocumentationMember]
        public List<BlankInterval> BlankIntervals { get; set; }
    }
}